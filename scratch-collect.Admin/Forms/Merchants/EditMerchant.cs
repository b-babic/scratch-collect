﻿using scratch_collect.Admin.Services;
using scratch_collect.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace scratch_collect.Admin.Forms.Merchants
{
    public partial class EditMerchant : Form
    {
        private AllMerchants _parentForm;
        private string _merchantID;

        public EditMerchant(AllMerchants parentForm, string merchantID)
        {
            InitializeComponent();

            // DI
            _parentForm = parentForm;
            _merchantID = merchantID;

            SetupInitialLayout();
            PrepareCountriesDropdown();
            FetchMerchantDetails(merchantID);
        }

        // Data
        private async void FetchMerchantDetails(string merchantID)
        {
            if (string.IsNullOrEmpty(merchantID)) return;

            UseWaitCursor = true;
            edit_merchant_button.Enabled = false;

            try
            {
                var merchant = await MerchantService.GetById(merchantID);

                if (merchant != null)
                {
                    // Populate grid data
                    name_input.Text = merchant.Name;
                    address_input.Text = merchant.Address;
                    telephone_input.Text = merchant.Telephone;

                    country_combobox.SelectedIndex = (int)merchant.Country.Id - 1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong", " Merchant", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ResetFormFields();
            }
            finally
            {
                UseWaitCursor = false;
                edit_merchant_button.Enabled = true;
            }
        }

        private void ResetFormFields()
        {
            name_input.Text = "";
            address_input.Text = "";
            telephone_input.Text = "";
            country_combobox.SelectedIndex = 0;

            edit_merchant_error_provider.Clear();
        }

        private async void edit_merchant_button_Click(object sender, EventArgs e)
        {
            var fieldsAreValid = validateAllFields();

            // Validate fields and show message
            if (!fieldsAreValid)
            {
                validation_label.Text = "* Please enter correct data and try again!";
                validation_label.Visible = true;

                return;
            }
            else
            {
                // Reset fields
                validation_label.Text = "";
                validation_label.Visible = false;
            }

            try
            {
                edit_merchant_button.Enabled = false;
                UseWaitCursor = true;

                var model = new MerchantUpsertRequest
                {
                    Id = Int32.Parse(_merchantID),
                    Name = name_input.Text,
                    Address = address_input.Text,
                    Telephone = telephone_input.Text,
                    CountryId = (int)country_combobox.SelectedValue
                };

                var updated = await MerchantService.Update(model);

                if (updated != null)
                {
                    MessageBox.Show("Successfully updated", " Merchant", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FetchMerchantDetails(updated.Id.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong", " User", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
            finally
            {
                UseWaitCursor = false;
                edit_merchant_button.Enabled = true;
            }
        }

        // Generic events
        private async void go_back_button_Click(object sender, EventArgs e)
        {
            // Data
            await _parentForm.FetchMerchantsData();

            // Show
            Close();
            _parentForm.Show();
        }

        // Validation events
        private void name_input_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validateName();
        }

        private bool validateName()
        {
            return validateRequiredText(name_input, "Name is required!", "Name cannot have more than 30 characters !");
        }

        private void address_input_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validateAddress();
        }

        private bool validateAddress()
        {
            return validateRequiredText(address_input, "Address is required !", "Address cannot have more than 30 characters!");
        }

        private void telephone_input_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validateTelephone();
        }

        private bool validateTelephone()
        {
            var value = telephone_input.Text;

            MatchCollection match = Regex.Matches(value, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");

            // Required
            if (string.IsNullOrEmpty(value))
            {
                edit_merchant_error_provider.SetError(telephone_input, "Telephone is required !");
                return false;
            }
            else if (match.Count <= 0)
            {
                edit_merchant_error_provider.SetError(telephone_input, "Telephone requires valid number !");
                return false;
            }
            else
            {
                edit_merchant_error_provider.Clear();
                return true;
            }
        }

        private bool validateRequiredText(TextBox control, string requiredMessage, string lengthMessage)
        {
            var value = control.Text;

            // Required
            if (string.IsNullOrEmpty(value))
            {
                edit_merchant_error_provider.SetError(control, requiredMessage);
                return false;
            }
            // Max length
            else if (value.Length > 30)
            {
                edit_merchant_error_provider.SetError(control, lengthMessage);
                return false;
            }
            else
            {
                edit_merchant_error_provider.Clear();
                return true;
            }
        }

        private bool validateAllFields()
        {
            var nameValid = validateName();
            var addressValid = validateAddress();
            var telephoneValid = validateTelephone();

            return nameValid &&
                addressValid &&
                telephoneValid;
        }

        // Helpers
        private async void PrepareCountriesDropdown()
        {
            country_combobox.Enabled = false;
            UseWaitCursor = true;

            try
            {
                var countries = await CountryService.GetAll();

                if (countries != null)
                {
                    // Populate data
                    country_combobox.DataSource = countries;
                    country_combobox.DisplayMember = "Name";
                    country_combobox.ValueMember = "Id";

                    UseWaitCursor = false;
                    country_combobox.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error while fetching list of all countries !");
            }
        }

        private void SetupInitialLayout()
        {
            // Hide validation labels
            validation_label.Text = "";
            validation_label.Visible = false;
        }
    }
}