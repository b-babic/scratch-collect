import 'package:flutter/widgets.dart';
import 'package:scratch_collect/modules/shared/theme/colors.dart';
import 'package:scratch_collect/modules/shared/theme/utils.dart';

class VoucherIntro extends StatelessWidget {
  const VoucherIntro({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Text(
          "Add voucher code",
          style: TextStyle(
            color: textColor,
            fontSize: getProportionateScreenWidth(28),
            fontWeight: FontWeight.bold,
          ),
        ),
        Text(
          "Use existing Voucher from the system",
          style: TextStyle(
            fontSize: getProportionateScreenWidth(16),
          ),
        ),
      ],
    );
  }
}