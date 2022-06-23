import 'package:flutter/widgets.dart';
import 'package:scratch_collect/modules/shared/theme/utils.dart';
import 'package:skeletons/skeletons.dart';

class ProfileBodyLoading extends StatelessWidget {
  const ProfileBodyLoading({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
        padding: const EdgeInsets.symmetric(vertical: 40, horizontal: 40),
        child: Column(
          children: <Widget>[
            Column(
              children: [
                SkeletonAvatar(
                  style: SkeletonAvatarStyle(
                    height: getProportionateScreenHeight(250),
                    width: getProportionateScreenWidth(250),
                    shape: BoxShape.circle,
                  ),
                )
              ],
            ),
            const SizedBox(height: 30),
            SkeletonLine(
                style: SkeletonLineStyle(
                    height: getProportionateScreenHeight(60))),
            const SizedBox(height: 20),
            SkeletonLine(
                style: SkeletonLineStyle(
                    height: getProportionateScreenHeight(60))),
            const SizedBox(height: 20),
            SkeletonLine(
                style: SkeletonLineStyle(
                    height: getProportionateScreenHeight(60))),
            const SizedBox(height: 20),
          ],
        ));
  }
}
