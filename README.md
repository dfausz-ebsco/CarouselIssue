## Issue seen in .Net MAUI in the Carousel View (Android only)

This is a solution made to reproduce an issue found with the CarouselView in .Net MAUI, it has a minimal set of changes from the basic MAUI project template.

The main page contains a CarouselView where the itemsource is just a list of 10 integers from 0-9 so that there are 10 items in the Carousel. The item template is just a picture that exists in the MAUI project template. 

This is what it looks like when the app is run, the picture is the first item in the CarouselView. 

![Screenshot_20240322-153450](https://github.com/dfausz-ebsco/CarouselIssue/assets/164557428/29895bb6-9706-4959-a977-96f4f16de083)


The issue is that there is inconsistent behevior when changing the orientatino of the device, the CarouselView seems to be stuck inbetween two items. After reaching this state you can swipe to change the CarouselView's selected element and the placement that it rests on will be correct.

![Screenshot_20240322-153520](https://github.com/dfausz-ebsco/CarouselIssue/assets/164557428/aeef6c3e-e796-45a2-a66a-d05502132218)

However, if you do swipe and change the CarouselView after encountering the issue in landscape mode, when you rotate the device back to portrait, the selected image will be slightly off center similar to the issue above but not as skewed. If you swipe to change the CarouselView in this state it will again correct itself.

![Screenshot_20240322-152802](https://github.com/dfausz-ebsco/CarouselIssue/assets/164557428/0745b33b-025b-4e27-916b-6f1ca1713cd7)
