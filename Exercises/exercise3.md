
# Importance of testing your projects

## Learnings

1. [Unit-Tests](#unit-tests)
1. [Build Automation with Unit-Tests](#build-automation-with-unit-tests)

## Unit-Tests
- Roman / Patrik

## Build Automation with Unit-Tests
The build template, created in [Exercise 2](exercise2.md) has to be changed.

1. Got to build definition
1. click **Edit** (top-right)
1. Add new build step
1. Select Category: Test / Visual Studio Test
![Build_Test_1](images/exercise3/Build_Test_1.png "Add Visual Studio Test build step")
1. Change the order of the build steps like picture below
![Build_Test_2](images/exercise3/Build_Test_2.png "New step order")
1. Select Test Assemblies step and change setting **Test Assembly** to '$(build.binariesdirectory)/$(BuildConfiguration)/test-assembly/Softaware.Test.dll'
![Build_Test_3](images/exercise3/Build_Test_3.png "Unit-Test build step")
1. Save changes and queue new build

After success the test results appear in the build results overview page.
![Build_Test_4](images/exercise3/Build_Test_4.png "Unit-Test build step")
