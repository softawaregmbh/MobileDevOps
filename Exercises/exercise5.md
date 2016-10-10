

# HockeyApp Integration - Build and User Feedback

## Learnings

1. [Register to HockeyApp](#register_to_hockeyapp)
1. [Connection between VSTS and HockeyApp](#connection_between_vsts_and_hockeyapp)
1. [Build integration](#build_integration)
1. [HockeyApp integration in project](#hockeyapp_integration_in_project)
1. [User feedback integration in project](#user_feedback_integration_in_project)

## Register to HockeyApp
1. Go to offical [HockeyApp](https://www.hockeyapp.net/) page
1. Sign up for free (Button top right)
1. Enter your data
1. Select the **I'm a developer** checkbox
1. Click on **Register** button to sign up.

![HockeyApp_SignUp](images/exercise5/HockeyApp_SignUp.png "Sign up to HockeyApp")

After sign up and login to the created account to create a new app. In the first dialog choose **create the app manually instead**.

![HockeyApp_Create_App_1](images/exercise5/HockeyApp_Create_App.png "Create HockeyApp App")

1. Select the platform (*Android*),
1. the release type (*beta*),
1. the title (*Hanselman.Forms*) and
1. the bundle identifier (*com.refractored.hanselman*)

![HockeyApp_Create_App_2](images/exercise5/HockeyApp_Create_App_2.png "Create HockeyApp App - Settings")

After creating the app with click on the save button the overview of the app appears.

![HockeyApp_App_Created](images/exercise5/HockeyApp_App_Created.png "App Dashboard")

## Connection between VSTS and HockeyApp
1. Go to the settings page with click on the **Manage App** button.
2. **Visual Studio Team Services** is the navigation point to use.
3. Click on **Configure**, enter your *VSTS* login infos and authorize the connection.

![HockeyApp_Attach_To_VSTS](images/exercise5/HockeyApp_Attach_To_VSTS.png "Connection between VSTS and HockeyApp")

Choose the correct *VSTS* project and check **Auto Create Ticket** on **Crash Groups** and **Feedback**.

![HockeyApp_Attach_To_VSTS](images/exercise5/HockeyApp_Attached_To_VSTS.png "Connection between VSTS and HockeyApp")

## Build integration
Next step is to integrate *HockeyApp* in the build automation process created in **exercise 2**. For build integration *VSTS* need an api key of our *HockeyApp* account. Create this key in the **Account Settings** - **API Tokens** and save it in the clipboard.

![HockeyApp_Api_Key](images/exercise5/HockeyApp_Api_Key.png "Created Api-Key in HockeyApp settings")

Then install the **HockeyApp-Extension** from the **VSTS Marketplace.**

![VSTS_Marketplace_HockeyApp](images/exercise5/VSTS_Install_Hockey_app.png "Install HockeyApp-Extension from marketplace")

1. Open the created build definition and click on **Edit**.
1. Add new build step
1. Select the before installed **HockeyApp-Extension** (Deploy category)
1. Click on close to add the selected task

![VSTS_Marketplace_HockeyApp](images/exercise5/VSTS_Build_Add_Hockey_App_Task.png "Add HockeyApp task to build definition")

The added task need a **HockeyApp Connection**.
1. Click on **Manage**, right beside the **HockeyApp Connection** input
1. Add new service endpoint
1. Choose **HockeyApp**
1. Input the name = "Sample.Hanselman.Forms"
1. Paste the before created *Api-Key* from clipboard

![VSTS_Service_Endpoint_1](images/exercise5/VSTS_Build_Add_Hockey_App_Service_1.png "Add new Service Endpoint")

![VSTS_Service_Endpoint_2](images/exercise5/VSTS_Build_Add_Hockey_App_Service_2.png "Add new HockeyApp Connection")

Back to the build definition, after refresh (click on the refresh button) the "Sample.Hanselman.Forms" connection should appear. Then save the build definition and queue a new build. After build succeeded the apk-File should appear in *HockeyApp*.

![VSTS_Service_Endpoint_2](images/exercise5/HockeyApp_After_First_Build.png "New version created in HockeyApp after build succeeded")

## HockeyApp integration in project

## User feedback integration in project

## Release Management
