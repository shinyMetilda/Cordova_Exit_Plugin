Cordova_Exit_Plugin
===================
STEP1:
Add file AppTerminate.cs to your platforms/wp8/Plugins folder


STEP2:
Edit Your platforms/wp8/config.xml and add the following code

<feature name="AppTerminate">
  <param name="wp-package" value="AppTerminate" />
</feature>

STEP3:
Call this function at the point where you want to terminate your app from the javascript file as follows

cordova.exec(null, null, "AppTerminate", "execute", []);
