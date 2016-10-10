



## Create a Visual Studio project
1. Open Visual Studio
1. Create a new project
1. Select "Visual C# > Cross-Platform" and choose the **Blank App (Xamarin.Forms Portable)** project
   ![Project template](images/exercise1/create-project.png)
1. Discuss the difference between the two code-sharing strategies **Portable** and **Shared** (see [Sharing Code Options](https://developer.xamarin.com/guides/cross-platform/application_fundamentals/building_cross_platform_applications/sharing_code_options/) for further details)
1. Name the project **HelloAndroid**
1. Discuss the created project structure<br/>
   ![Project structure](images/exercise1/project-structure.png)

## Add NuGet-Packages
1. Open the NuGet Manager dialog for the project **HelloXamarin (Portable)**
1. Add **Microsoft.Net.Http**
1. Add **Newtonsoft.Json**
1. Add **MvvmLightLibs**<br/>
   ![MvvmLight](images/exercise1/mvvmlight.png)

## Create a ViewModel
1. Discuss MVVM architecture briefly
1. Create a folder **ViewModels** in the **HelloXamarin (Portable)** project
1. Create a class **AlbumViewModel.cs** in this folder
1. 





## Setup environment
1. Set Java heap size in the app project settings
   ![Set Java heap size](images/exercise1/JavaMaxHeapSize.png)
1. **Important**: The first build of the Xamarin app may last up to several minutes. Do not interrupt the build process as some download tasks are running in the background.


## Update Xamarin
1. Open Visual Studio
1. Open "Tools > Options" and select "Xamarin"<br/>
   ![Xamarin Other](images/exercise1/xamarin-updates.png)
1. Click "Check now"
1. Download and install update if available<br/>
   ![Xamarin Update](images/exercise1/xamarin-download.png)

## Delete Visual Studio ComponentModelCache
If you encounter error messages when creating a new Xamarin project (e.g. "A problem was encountered creating the sub project 'HelloAndroid.Droid'. Attempted to access a missing method."), try to remove the ComponentModelCache:
1. Close Visual Studio
1. Open file explorer in "%localappdata%\Microsoft\VisualStudio\14.0\ComponentModelCache"
1. Delete all the files
1. Open Visual Studio