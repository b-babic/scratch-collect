import 'package:flutter/material.dart';
import 'package:scratch_collect/modules/home/models/offer_details_arguments.model.dart';
import 'package:scratch_collect/modules/home/widgets/details_app_bar.dart';
import 'package:scratch_collect/modules/home/widgets/details_body.dart';
import 'package:scratch_collect/modules/shared/theme/colors.dart';

class DetailsScreen extends StatelessWidget {
  static String routeName = "/details";

  const DetailsScreen({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final OfferDetailsArguments args =
        ModalRoute.of(context)!.settings.arguments as OfferDetailsArguments;

    return Scaffold(
      backgroundColor: whiteColor,
      appBar: PreferredSize(
        preferredSize: Size.fromHeight(AppBar().preferredSize.height),
        // TODO: Add rating to the offer model ?
        child: const DetailsAppBar(rating: 2),
      ),
      body: DetailsBody(id: args.id),
    );
  }
}