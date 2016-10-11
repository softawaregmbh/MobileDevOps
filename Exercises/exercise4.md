# Automated Testing using Xamarin Test Cloud

## Learnings

1. How to sign up for a Xamarin Test Cloud account 
1. Create a coded UI test
1. Record an UI test by using Xamarin Test Recorder
1. Run tests in the cloud 

## Sign up for a free trial of Xamarin Test Cloud
1. Open [Xamarin Website](https://www.xamarin.com/)
1. Choose Products > Xamarin Test Cloud
1. Click on "Start your free trial"
   ![Xamarin Cloud Free Trial](images/exercise4/XamarinCloudFreeTrial.png)
1. Register<br/>
   ![Xamarin Cloud Free Register](images/exercise4/XamarinCloudRegister.png)

## Create a new Test Project in Visual Studio
1. Open **Visual Studio**
1. Open the **Hanselman.Forms** solution
1. Add a new **Class Library** Project called "Hanselman.Tests"
   ![Create a Class Library](images/exercise4/ClassLibraryProject.png)
1. **Rename** ```Class1.cs``` to ```Tests.cs```
1. Add **NuGet** packages<br/>
   **Important: choose the specified versions:** Xamarin.UITest requires NUnit 2.6.3 or higher. Xamarin.UITest is not compatible with NUnit 3.0.

   * ```Install-Package NUnit -Version 2.6.4 ```
   * ```Install-Package NUnitTestAdapter -Version 2.0.0```
   * ```Install-Package Xamarin.UITest -Version 1.3.8```

   ![Add NuGet packages](images/exercise4/nuget.PNG)

## Create your first test
```
public class Tests
{
    private IApp app;

    [SetUp]
    public void BeforeEachTest()
    {
        app = ConfigureApp
            .Android
            .StartApp();
    }

    [Test]
    public void AppLaunches()
    {
        app.Screenshot("First screen.");
    }
}
```

## Create a more advanced test

Detailed functionality can be found at [Xamarin.UITest.IApp](https://developer.xamarin.com/api/type/Xamarin.UITest.IApp/), e.g.
* Back
* Tap / DoubleTap
* EnterText
* PressEnter
* PinchToZoomIn
* SetOrientationLandscape / SetOrientationPortrait
* SwipeLeft / SwipeRight
* Screenshot

## Run tests
1. Make a release build of the app
1. Create an .apk file<br/>
   ![Create an apk file](images/exercise4/CreateApk.png)
1. Publish to Xamarin Test Cloud   
   ![Publish to Xamarin Test Cloud](images/exercise4/PublishTests.png)
1. Select target devices for the test (Note: Using the trial edition restricts the amount of parallel tested devices to 3.)
   ![Device selection](images/exercise4/XamarinTestCloudSelectDevice.PNG)

## Record tests using Test Recorder
**Important:** This feature is only available in Visual Studio Enterprise edition. Explain the idea or show the following steps live.

1. **Install the Xamarin Test Recorder** through Visual Studio > Tools > Extensions and Updates
1. Open the properties of your **Hanselman.Android** project and disable **Use Shared Runtime**<br/>
   ![Use shared runtime](images/exercise4/XamarinTestRecorderSharedRuntime.png)
1. Open the **Tests.cs** class from your UI test project
1. Click on the Test Recorder icon and select **Record new test > Build Hanselman.Android project**<br/>
   ![Test Recorder](images/exercise4/XamarinTestRecorderRecord.png)
1. The app is started in the emulator, wait until it is loaded completely.
1. Click through several pages in the app, you will see the recorded actions live in Visual Studio
1. Go to Visual Studio to stop the current test case.<br/>
   ![Stop Test Recorder](images/exercise4/XamarinTestRecorderStop.png)


## Relevant Links:
* [NUnit](http://www.nunit.org/)
* [Introduction to Xamarin Test Cloud](https://developer.xamarin.com/guides/testcloud/introduction-to-test-cloud)  
* [Introdution to Xamarin.UITest](https://developer.xamarin.com/guides/testcloud/uitest/intro-to-uitest/)
* [Xamarin.UITest Quick Starts](https://developer.xamarin.com/guides/testcloud/uitest/quickstarts/)
* [Submitting UITests to Xamarin Test Cloud](https://developer.xamarin.com/guides/testcloud/uitest/working-with/submitting-tests-to-xamarin-test-cloud/)
