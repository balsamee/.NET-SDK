# Getting started

TODO: Add Description

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (BalsameeAPIs.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Balsamee-APIs-CSharp&workspaceName=BalsameeAPIs&projectName=BalsameeAPIs.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the BalsameeAPIs library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Balsamee-APIs-CSharp&workspaceName=BalsameeAPIs&projectName=BalsameeAPIs.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Balsamee-APIs-CSharp&workspaceName=BalsameeAPIs&projectName=BalsameeAPIs.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Balsamee-APIs-CSharp&workspaceName=BalsameeAPIs&projectName=BalsameeAPIs.Standard)

### 3. Add reference of the library project

In order to use the BalsameeAPIs library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Balsamee-APIs-CSharp&workspaceName=BalsameeAPIs&projectName=BalsameeAPIs.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` BalsameeAPIs.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```BalsameeAPIs.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Balsamee-APIs-CSharp&workspaceName=BalsameeAPIs&projectName=BalsameeAPIs.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Balsamee-APIs-CSharp&workspaceName=BalsameeAPIs&projectName=BalsameeAPIs.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### 

API client can be initialized as following.

```csharp

BalsameeAPIsClient client = new BalsameeAPIsClient();
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [NewsTagsController](#news_tags_controller)
* [StaticPagesController](#static_pages_controller)
* [GeneralController](#general_controller)
* [MiscController](#misc_controller)
* [MiniPmrController](#mini_pmr_controller)
* [ListRadiologyRequestGroupsController](#list_radiology_request_groups_controller)
* [RadiologyRequestImageGroupController](#radiology_request_image_group_controller)
* [PrescriptionsController](#prescriptions_controller)
* [LabRequestGroupsController](#lab_request_groups_controller)
* [PrescriptionGroupsController](#prescription_groups_controller)
* [LabRequestImagesGroupController](#lab_request_images_group_controller)
* [LabResultsController](#lab_results_controller)
* [PrescriptionImagesGroupController](#prescription_images_group_controller)
* [MedicalProfileController](#medical_profile_controller)
* [LifestylesController](#lifestyles_controller)
* [ChronicDiseasesController](#chronic_diseases_controller)
* [AllergiesController](#allergies_controller)
* [IndividualImagesController](#individual_images_controller)
* [SurgeriesController](#surgeries_controller)
* [MeasurementsRevampV5Controller](#measurements_revamp_v5_controller)
* [ReservationRequestsController](#reservation_requests_controller)
* [NewsFeedController](#news_feed_controller)
* [EventsController](#events_controller)
* [NearbyLocationsController](#nearby_locations_controller)
* [AppointmentsController](#appointments_controller)
* [SessionController](#session_controller)
* [LabRequestsController](#lab_requests_controller)
* [DrugsController](#drugs_controller)
* [PlacesController](#places_controller)
* [DoctorsController](#doctors_controller)
* [CrossBorderTreatmentsController](#cross_border_treatments_controller)
* [CommentsController](#comments_controller)
* [PaypalController](#paypal_controller)
* [DicomMREsController](#dicom_mr_es_controller)
* [VideoRequestsController](#video_requests_controller)
* [PrescriptionImagesController](#prescription_images_controller)
* [LikesController](#likes_controller)
* [VideoExtensionController](#video_extension_controller)
* [EditProfileController](#edit_profile_controller)
* [AdvertisementsController](#advertisements_controller)
* [ResetPasswordController](#reset_password_controller)
* [MessagesController](#messages_controller)
* [LabRequestImagesController](#lab_request_images_controller)
* [MeasurementsController](#measurements_controller)
* [ConfirmationController](#confirmation_controller)

## <a name="news_tags_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.NewsTagsController") NewsTagsController

### Get singleton instance

The singleton instance of the ``` NewsTagsController ``` class can be accessed from the API Client.

```csharp
NewsTagsController newsTags = client.NewsTags;
```

### <a name="get_api_v5_news_tags_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.NewsTagsController.GetApiV5NewsTagsGet") GetApiV5NewsTagsGet

> TODO: Add Description


```csharp
Task GetApiV5NewsTagsGet()
```

#### Example Usage

```csharp

await newsTags.GetApiV5NewsTagsGet();

```


[Back to List of Controllers](#list_of_controllers)

## <a name="static_pages_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.StaticPagesController") StaticPagesController

### Get singleton instance

The singleton instance of the ``` StaticPagesController ``` class can be accessed from the API Client.

```csharp
StaticPagesController staticPages = client.StaticPages;
```

### <a name="get_api_v5_call_center_number_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.StaticPagesController.GetApiV5CallCenterNumberGet") GetApiV5CallCenterNumberGet

> TODO: Add Description


```csharp
Task GetApiV5CallCenterNumberGet()
```

#### Example Usage

```csharp

await staticPages.GetApiV5CallCenterNumberGet();

```


### <a name="get_api_v5_terms_and_conditions_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.StaticPagesController.GetApiV5TermsAndConditionsGet") GetApiV5TermsAndConditionsGet

> Return terms and conditions html page
> 
> Parameters
> 
> # lang - [ar,en]


```csharp
Task GetApiV5TermsAndConditionsGet(string lang)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| lang |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string lang = "lang";

await staticPages.GetApiV5TermsAndConditionsGet(lang);

```


### <a name="get_api_v5_privacy_policy_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.StaticPagesController.GetApiV5PrivacyPolicyGet") GetApiV5PrivacyPolicyGet

> Privacy Policy html page
> 
> Parameters
> 
> # lang - [ar,en]


```csharp
Task GetApiV5PrivacyPolicyGet(string lang)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| lang |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string lang = "lang";

await staticPages.GetApiV5PrivacyPolicyGet(lang);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="general_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.GeneralController") GeneralController

### Get singleton instance

The singleton instance of the ``` GeneralController ``` class can be accessed from the API Client.

```csharp
GeneralController general = client.General;
```

### <a name="get_api_v5_specialities_with_career_levels_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.GeneralController.GetApiV5SpecialitiesWithCareerLevelsGet") GetApiV5SpecialitiesWithCareerLevelsGet

> Return career levels with specialities


```csharp
Task GetApiV5SpecialitiesWithCareerLevelsGet()
```

#### Example Usage

```csharp

await general.GetApiV5SpecialitiesWithCareerLevelsGet();

```


### <a name="get_api_v5_search_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.GeneralController.GetApiV5SearchGet") GetApiV5SearchGet

> Search news


```csharp
Task GetApiV5SearchGet(string q)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| q |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string q = "q";

await general.GetApiV5SearchGet(q);

```


### <a name="get_api_v5_app_version_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.GeneralController.GetApiV5AppVersionGet") GetApiV5AppVersionGet

> TODO: Add Description


```csharp
Task GetApiV5AppVersionGet(DateTime appVersion, string xAppId, string userAgent)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| appVersion |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |
| userAgent |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
DateTime appVersion = DateTime.Now();
string xAppId = "X-App-Id";
string userAgent = "User-Agent";

await general.GetApiV5AppVersionGet(appVersion, xAppId, userAgent);

```


### <a name="create_api_v5_doctor_requests_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.GeneralController.CreateApiV5DoctorRequestsPost") CreateApiV5DoctorRequestsPost

> TODO: Add Description


```csharp
Task CreateApiV5DoctorRequestsPost(
        string xAuthenticationToken,
        string xSessionId,
        string careerLevelId,
        string specialityId,
        string mobileNumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| careerLevelId |  ``` Required ```  | TODO: Add a parameter description |
| specialityId |  ``` Required ```  | TODO: Add a parameter description |
| mobileNumber |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string careerLevelId = "career_level_id";
string specialityId = "speciality_id";
string mobileNumber = "mobile_number";

await general.CreateApiV5DoctorRequestsPost(xAuthenticationToken, xSessionId, careerLevelId, specialityId, mobileNumber);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="misc_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.MiscController") MiscController

### Get singleton instance

The singleton instance of the ``` MiscController ``` class can be accessed from the API Client.

```csharp
MiscController misc = client.Misc;
```

### <a name="create_api_v5_doctor_availability_notifications_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MiscController.CreateApiV5DoctorAvailabilityNotificationsPost") CreateApiV5DoctorAvailabilityNotificationsPost

> TODO: Add Description


```csharp
Task CreateApiV5DoctorAvailabilityNotificationsPost(
        string xSessionId,
        string xAuthenticationToken,
        string doctorAvailabilityNotificationSpecialityId,
        string doctorAvailabilityNotificationRequestType)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| doctorAvailabilityNotificationSpecialityId |  ``` Required ```  | TODO: Add a parameter description |
| doctorAvailabilityNotificationRequestType |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string doctorAvailabilityNotificationSpecialityId = "doctor_availability_notification[speciality_id]";
string doctorAvailabilityNotificationRequestType = "doctor_availability_notification[request_type]";

await misc.CreateApiV5DoctorAvailabilityNotificationsPost(xSessionId, xAuthenticationToken, doctorAvailabilityNotificationSpecialityId, doctorAvailabilityNotificationRequestType);

```


### <a name="create_api_v5_contact_request_contact_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MiscController.CreateApiV5ContactRequestContactPost") CreateApiV5ContactRequestContactPost

> TODO: Add Description


```csharp
Task CreateApiV5ContactRequestContactPost(
        string contentType,
        string mailName,
        string mailEmail,
        string mailFormType,
        string mailMessage)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| mailName |  ``` Required ```  | TODO: Add a parameter description |
| mailEmail |  ``` Required ```  | TODO: Add a parameter description |
| mailFormType |  ``` Required ```  | TODO: Add a parameter description |
| mailMessage |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string contentType = "Content-Type";
string mailName = "mail[name]";
string mailEmail = "mail[email]";
string mailFormType = "mail[form_type]";
string mailMessage = "mail[message]";

await misc.CreateApiV5ContactRequestContactPost(contentType, mailName, mailEmail, mailFormType, mailMessage);

```


### <a name="get_api_v5_reservation_requests3263_mres_visit_medical_data_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MiscController.GetApiV5ReservationRequests3263MresVisitMedicalDataGet") GetApiV5ReservationRequests3263MresVisitMedicalDataGet

> TODO: Add Description


```csharp
Task GetApiV5ReservationRequests3263MresVisitMedicalDataGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await misc.GetApiV5ReservationRequests3263MresVisitMedicalDataGet(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="mini_pmr_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.MiniPmrController") MiniPmrController

### Get singleton instance

The singleton instance of the ``` MiniPmrController ``` class can be accessed from the API Client.

```csharp
MiniPmrController miniPmr = client.MiniPmr;
```

### <a name="get_api_v5_individuals_medical_profile_statistics_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MiniPmrController.GetApiV5IndividualsMedicalProfileStatisticsGet") GetApiV5IndividualsMedicalProfileStatisticsGet

> TODO: Add Description


```csharp
Task GetApiV5IndividualsMedicalProfileStatisticsGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await miniPmr.GetApiV5IndividualsMedicalProfileStatisticsGet(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_radiology_scans_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MiniPmrController.GetApiV5RadiologyScansGet") GetApiV5RadiologyScansGet

> TODO: Add Description


```csharp
Task<Models.ListRadiologyScans> GetApiV5RadiologyScansGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

Models.ListRadiologyScans result = await miniPmr.GetApiV5RadiologyScansGet(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="list_radiology_request_groups_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.ListRadiologyRequestGroupsController") ListRadiologyRequestGroupsController

### Get singleton instance

The singleton instance of the ``` ListRadiologyRequestGroupsController ``` class can be accessed from the API Client.

```csharp
ListRadiologyRequestGroupsController listRadiologyRequestGroups = client.ListRadiologyRequestGroups;
```

### <a name="get_api_v5_radiology_request_groups_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ListRadiologyRequestGroupsController.GetApiV5RadiologyRequestGroupsGet") GetApiV5RadiologyRequestGroupsGet

> TODO: Add Description


```csharp
Task<Models.Listradiologyrequestgroupfile> GetApiV5RadiologyRequestGroupsGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

Models.Listradiologyrequestgroupfile result = await listRadiologyRequestGroups.GetApiV5RadiologyRequestGroupsGet(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="radiology_request_image_group_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.RadiologyRequestImageGroupController") RadiologyRequestImageGroupController

### Get singleton instance

The singleton instance of the ``` RadiologyRequestImageGroupController ``` class can be accessed from the API Client.

```csharp
RadiologyRequestImageGroupController radiologyRequestImageGroup = client.RadiologyRequestImageGroup;
```

### <a name="create_api_v5_reservation_requests4323_radiology_request_image_groups_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.RadiologyRequestImageGroupController.CreateApiV5ReservationRequests4323RadiologyRequestImageGroupsPost") CreateApiV5ReservationRequests4323RadiologyRequestImageGroupsPost

> TODO: Add Description


```csharp
Task<Models.Uploadradiologyrequestimagegroupfileforreservationrequestcopy> CreateApiV5ReservationRequests4323RadiologyRequestImageGroupsPost(string xSessionId, string xAuthenticationToken, string radiologyRequestImageGroupRadiologyRequestImagesAttributesImage)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| radiologyRequestImageGroupRadiologyRequestImagesAttributesImage |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string radiologyRequestImageGroupRadiologyRequestImagesAttributesImage = "radiology_request_image_group[radiology_request_images_attributes][][image]";

Models.Uploadradiologyrequestimagegroupfileforreservationrequestcopy result = await radiologyRequestImageGroup.CreateApiV5ReservationRequests4323RadiologyRequestImageGroupsPost(xSessionId, xAuthenticationToken, radiologyRequestImageGroupRadiologyRequestImagesAttributesImage);

```


### <a name="get_api_v5_reservation_requests4323_radiology_request_image_groups_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.RadiologyRequestImageGroupController.GetApiV5ReservationRequests4323RadiologyRequestImageGroupsGet") GetApiV5ReservationRequests4323RadiologyRequestImageGroupsGet

> TODO: Add Description


```csharp
Task<Models.Listradiologyrequestimagegroupfileforreservationrequest> GetApiV5ReservationRequests4323RadiologyRequestImageGroupsGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

Models.Listradiologyrequestimagegroupfileforreservationrequest result = await radiologyRequestImageGroup.GetApiV5ReservationRequests4323RadiologyRequestImageGroupsGet(xSessionId, xAuthenticationToken);

```


### <a name="create_api_v5_radiology_request_image_groups_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.RadiologyRequestImageGroupController.CreateApiV5RadiologyRequestImageGroupsPost") CreateApiV5RadiologyRequestImageGroupsPost

> TODO: Add Description


```csharp
Task<Models.Uploadradiologyrequestimagegroupfile> CreateApiV5RadiologyRequestImageGroupsPost(string xSessionId, string xAuthenticationToken, string radiologyRequestImageGroupRadiologyRequestImagesAttributesImage)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| radiologyRequestImageGroupRadiologyRequestImagesAttributesImage |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string radiologyRequestImageGroupRadiologyRequestImagesAttributesImage = "radiology_request_image_group[radiology_request_images_attributes][][image]";

Models.Uploadradiologyrequestimagegroupfile result = await radiologyRequestImageGroup.CreateApiV5RadiologyRequestImageGroupsPost(xSessionId, xAuthenticationToken, radiologyRequestImageGroupRadiologyRequestImagesAttributesImage);

```


### <a name="get_api_v5_radiology_request_image_groups_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.RadiologyRequestImageGroupController.GetApiV5RadiologyRequestImageGroupsGet") GetApiV5RadiologyRequestImageGroupsGet

> TODO: Add Description


```csharp
Task<Models.Listradiologyrequestimagegroupfile> GetApiV5RadiologyRequestImageGroupsGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

Models.Listradiologyrequestimagegroupfile result = await radiologyRequestImageGroup.GetApiV5RadiologyRequestImageGroupsGet(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="prescriptions_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.PrescriptionsController") PrescriptionsController

### Get singleton instance

The singleton instance of the ``` PrescriptionsController ``` class can be accessed from the API Client.

```csharp
PrescriptionsController prescriptions = client.Prescriptions;
```

### <a name="create_api_v5_prescriptions_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PrescriptionsController.CreateApiV5PrescriptionsPost") CreateApiV5PrescriptionsPost

> TODO: Add Description


```csharp
Task CreateApiV5PrescriptionsPost(
        string xSessionId,
        string xAuthenticationToken,
        string prescriptionDate,
        string prescriptionPrescriber,
        string prescriptionPresDrugsAttributes0StartDate,
        string prescriptionPresDrugsAttributes0Num,
        string prescriptionPresDrugsAttributes0Duration,
        string prescriptionPresDrugsAttributes0DrugId,
        string prescriptionPresDrugsAttributes0Dose,
        string prescriptionPresDrugsAttributes0Notes,
        string prescriptionPresDrugsAttributes1461845708794StartDate,
        string prescriptionPresDrugsAttributes1461845708794Num,
        string prescriptionPresDrugsAttributes1461845708794Duration,
        string prescriptionPresDrugsAttributes1461845708794DrugId,
        string prescriptionPresDrugsAttributes1461845708794Dose,
        string prescriptionPresDrugsAttributes1461845708794Destroy)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionDate |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionPrescriber |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionPresDrugsAttributes0StartDate |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionPresDrugsAttributes0Num |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionPresDrugsAttributes0Duration |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionPresDrugsAttributes0DrugId |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionPresDrugsAttributes0Dose |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionPresDrugsAttributes0Notes |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionPresDrugsAttributes1461845708794StartDate |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionPresDrugsAttributes1461845708794Num |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionPresDrugsAttributes1461845708794Duration |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionPresDrugsAttributes1461845708794DrugId |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionPresDrugsAttributes1461845708794Dose |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionPresDrugsAttributes1461845708794Destroy |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string prescriptionDate = "prescription[date]";
string prescriptionPrescriber = "prescription[prescriber]";
string prescriptionPresDrugsAttributes0StartDate = "prescription[pres_drugs_attributes][0][start_date]";
string prescriptionPresDrugsAttributes0Num = "prescription[pres_drugs_attributes][0][num]";
string prescriptionPresDrugsAttributes0Duration = "prescription[pres_drugs_attributes][0][duration]";
string prescriptionPresDrugsAttributes0DrugId = "prescription[pres_drugs_attributes][0][drug_id]";
string prescriptionPresDrugsAttributes0Dose = "prescription[pres_drugs_attributes][0][dose]";
string prescriptionPresDrugsAttributes0Notes = "prescription[pres_drugs_attributes][0][notes]";
string prescriptionPresDrugsAttributes1461845708794StartDate = "prescription[pres_drugs_attributes][1461845708794][start_date]";
string prescriptionPresDrugsAttributes1461845708794Num = "prescription[pres_drugs_attributes][1461845708794][num]";
string prescriptionPresDrugsAttributes1461845708794Duration = "prescription[pres_drugs_attributes][1461845708794][duration]";
string prescriptionPresDrugsAttributes1461845708794DrugId = "prescription[pres_drugs_attributes][1461845708794][drug_id]";
string prescriptionPresDrugsAttributes1461845708794Dose = "prescription[pres_drugs_attributes][1461845708794][dose]";
string prescriptionPresDrugsAttributes1461845708794Destroy = "prescription[pres_drugs_attributes][1461845708794][_destroy]";

await prescriptions.CreateApiV5PrescriptionsPost(xSessionId, xAuthenticationToken, prescriptionDate, prescriptionPrescriber, prescriptionPresDrugsAttributes0StartDate, prescriptionPresDrugsAttributes0Num, prescriptionPresDrugsAttributes0Duration, prescriptionPresDrugsAttributes0DrugId, prescriptionPresDrugsAttributes0Dose, prescriptionPresDrugsAttributes0Notes, prescriptionPresDrugsAttributes1461845708794StartDate, prescriptionPresDrugsAttributes1461845708794Num, prescriptionPresDrugsAttributes1461845708794Duration, prescriptionPresDrugsAttributes1461845708794DrugId, prescriptionPresDrugsAttributes1461845708794Dose, prescriptionPresDrugsAttributes1461845708794Destroy);

```


### <a name="get_api_v5_reservation_requests4271_prescriptions_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PrescriptionsController.GetApiV5ReservationRequests4271PrescriptionsGet") GetApiV5ReservationRequests4271PrescriptionsGet

> TODO: Add Description


```csharp
Task GetApiV5ReservationRequests4271PrescriptionsGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await prescriptions.GetApiV5ReservationRequests4271PrescriptionsGet(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_prescriptions5a1bf82474617232620b0000_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PrescriptionsController.GetApiV5Prescriptions5a1bf82474617232620b0000Get") GetApiV5Prescriptions5a1bf82474617232620b0000Get

> TODO: Add Description


```csharp
Task GetApiV5Prescriptions5a1bf82474617232620b0000Get(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await prescriptions.GetApiV5Prescriptions5a1bf82474617232620b0000Get(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_reservation_requests46464634_prescriptions5a1bf82474617232620b0000_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PrescriptionsController.GetApiV5ReservationRequests46464634Prescriptions5a1bf82474617232620b0000Get") GetApiV5ReservationRequests46464634Prescriptions5a1bf82474617232620b0000Get

> TODO: Add Description


```csharp
Task GetApiV5ReservationRequests46464634Prescriptions5a1bf82474617232620b0000Get(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await prescriptions.GetApiV5ReservationRequests46464634Prescriptions5a1bf82474617232620b0000Get(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_prescriptions_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PrescriptionsController.GetApiV5PrescriptionsGet") GetApiV5PrescriptionsGet

> TODO: Add Description


```csharp
Task GetApiV5PrescriptionsGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await prescriptions.GetApiV5PrescriptionsGet(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="lab_request_groups_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.LabRequestGroupsController") LabRequestGroupsController

### Get singleton instance

The singleton instance of the ``` LabRequestGroupsController ``` class can be accessed from the API Client.

```csharp
LabRequestGroupsController labRequestGroups = client.LabRequestGroups;
```

### <a name="get_api_v5_lab_request_groups_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LabRequestGroupsController.GetApiV5LabRequestGroupsGet") GetApiV5LabRequestGroupsGet

> TODO: Add Description


```csharp
Task GetApiV5LabRequestGroupsGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await labRequestGroups.GetApiV5LabRequestGroupsGet(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_reservation_requests2631_lab_request_groups_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LabRequestGroupsController.GetApiV5ReservationRequests2631LabRequestGroupsGet") GetApiV5ReservationRequests2631LabRequestGroupsGet

> TODO: Add Description


```csharp
Task<Models.IndexlabrequestsgroupsforreservationrequestClinicvisit> GetApiV5ReservationRequests2631LabRequestGroupsGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

Models.IndexlabrequestsgroupsforreservationrequestClinicvisit result = await labRequestGroups.GetApiV5ReservationRequests2631LabRequestGroupsGet(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="prescription_groups_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.PrescriptionGroupsController") PrescriptionGroupsController

### Get singleton instance

The singleton instance of the ``` PrescriptionGroupsController ``` class can be accessed from the API Client.

```csharp
PrescriptionGroupsController prescriptionGroups = client.PrescriptionGroups;
```

### <a name="get_api_v5_prescription_groups_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PrescriptionGroupsController.GetApiV5PrescriptionGroupsGet") GetApiV5PrescriptionGroupsGet

> TODO: Add Description


```csharp
Task GetApiV5PrescriptionGroupsGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await prescriptionGroups.GetApiV5PrescriptionGroupsGet(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_reservation_requests4271_prescription_groups_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PrescriptionGroupsController.GetApiV5ReservationRequests4271PrescriptionGroupsGet") GetApiV5ReservationRequests4271PrescriptionGroupsGet

> TODO: Add Description


```csharp
Task<Models.ListPrescriptionsgroupsundercertainclinicvisit> GetApiV5ReservationRequests4271PrescriptionGroupsGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

Models.ListPrescriptionsgroupsundercertainclinicvisit result = await prescriptionGroups.GetApiV5ReservationRequests4271PrescriptionGroupsGet(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="lab_request_images_group_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.LabRequestImagesGroupController") LabRequestImagesGroupController

### Get singleton instance

The singleton instance of the ``` LabRequestImagesGroupController ``` class can be accessed from the API Client.

```csharp
LabRequestImagesGroupController labRequestImagesGroup = client.LabRequestImagesGroup;
```

### <a name="create_api_v5_lab_request_images_groups_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LabRequestImagesGroupController.CreateApiV5LabRequestImagesGroupsPost") CreateApiV5LabRequestImagesGroupsPost

> TODO: Add Description


```csharp
Task CreateApiV5LabRequestImagesGroupsPost(string xSessionId, string xAuthenticationToken, string labRequestImagesGroupLabRequestImagesAttributesImage)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| labRequestImagesGroupLabRequestImagesAttributesImage |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string labRequestImagesGroupLabRequestImagesAttributesImage = "lab_request_images_group[lab_request_images_attributes][][image]";

await labRequestImagesGroup.CreateApiV5LabRequestImagesGroupsPost(xSessionId, xAuthenticationToken, labRequestImagesGroupLabRequestImagesAttributesImage);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="lab_results_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.LabResultsController") LabResultsController

### Get singleton instance

The singleton instance of the ``` LabResultsController ``` class can be accessed from the API Client.

```csharp
LabResultsController labResults = client.LabResults;
```

### <a name="get_api_v5_reservation_requests2631_lab_requests535_test_results_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LabResultsController.GetApiV5ReservationRequests2631LabRequests535TestResultsGet") GetApiV5ReservationRequests2631LabRequests535TestResultsGet

> TODO: Add Description


```csharp
Task GetApiV5ReservationRequests2631LabRequests535TestResultsGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await labResults.GetApiV5ReservationRequests2631LabRequests535TestResultsGet(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_lab_requests599_test_results12_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LabResultsController.GetApiV5LabRequests599TestResults12Get") GetApiV5LabRequests599TestResults12Get

> TODO: Add Description


```csharp
Task GetApiV5LabRequests599TestResults12Get(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await labResults.GetApiV5LabRequests599TestResults12Get(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="prescription_images_group_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.PrescriptionImagesGroupController") PrescriptionImagesGroupController

### Get singleton instance

The singleton instance of the ``` PrescriptionImagesGroupController ``` class can be accessed from the API Client.

```csharp
PrescriptionImagesGroupController prescriptionImagesGroup = client.PrescriptionImagesGroup;
```

### <a name="create_api_v5_reservation_requests2668_prescription_images_groups_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PrescriptionImagesGroupController.CreateApiV5ReservationRequests2668PrescriptionImagesGroupsPost") CreateApiV5ReservationRequests2668PrescriptionImagesGroupsPost

> TODO: Add Description


```csharp
Task CreateApiV5ReservationRequests2668PrescriptionImagesGroupsPost(
        string xSessionId,
        string xAuthenticationToken,
        string xAppId,
        string prescriptionImagesGroupPrescriptionImagesAttributesImage)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionImagesGroupPrescriptionImagesAttributesImage |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";
string prescriptionImagesGroupPrescriptionImagesAttributesImage = "prescription_images_group[prescription_images_attributes][][image]";

await prescriptionImagesGroup.CreateApiV5ReservationRequests2668PrescriptionImagesGroupsPost(xSessionId, xAuthenticationToken, xAppId, prescriptionImagesGroupPrescriptionImagesAttributesImage);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="medical_profile_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.MedicalProfileController") MedicalProfileController

### Get singleton instance

The singleton instance of the ``` MedicalProfileController ``` class can be accessed from the API Client.

```csharp
MedicalProfileController medicalProfile = client.MedicalProfile;
```

### <a name="update_api_v5_individuals_update_medical_profile_put"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MedicalProfileController.UpdateApiV5IndividualsUpdateMedicalProfilePut") UpdateApiV5IndividualsUpdateMedicalProfilePut

> TODO: Add Description


```csharp
Task UpdateApiV5IndividualsUpdateMedicalProfilePut(
        string xAuthenticationToken,
        string xSessionId,
        string individualBirthDate,
        string individualGender,
        string individualBloodGroup,
        string individualRelationshipStatus,
        string individualChildrenNumber,
        string individualNotes)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| individualBirthDate |  ``` Required ```  | TODO: Add a parameter description |
| individualGender |  ``` Required ```  | TODO: Add a parameter description |
| individualBloodGroup |  ``` Required ```  | TODO: Add a parameter description |
| individualRelationshipStatus |  ``` Required ```  | TODO: Add a parameter description |
| individualChildrenNumber |  ``` Required ```  | TODO: Add a parameter description |
| individualNotes |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string individualBirthDate = "individual[birth_date]";
string individualGender = "individual[gender]";
string individualBloodGroup = "individual[blood_group]";
string individualRelationshipStatus = "individual[relationship_status]";
string individualChildrenNumber = "individual[children_number]";
string individualNotes = "individual[notes]";

await medicalProfile.UpdateApiV5IndividualsUpdateMedicalProfilePut(xAuthenticationToken, xSessionId, individualBirthDate, individualGender, individualBloodGroup, individualRelationshipStatus, individualChildrenNumber, individualNotes);

```


### <a name="get_api_v5_individuals_medical_profile_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MedicalProfileController.GetApiV5IndividualsMedicalProfileGet") GetApiV5IndividualsMedicalProfileGet

> TODO: Add Description


```csharp
Task<Models.Getmedicalprofile> GetApiV5IndividualsMedicalProfileGet(string xAuthenticationToken, string xSessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";

Models.Getmedicalprofile result = await medicalProfile.GetApiV5IndividualsMedicalProfileGet(xAuthenticationToken, xSessionId);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="lifestyles_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.LifestylesController") LifestylesController

### Get singleton instance

The singleton instance of the ``` LifestylesController ``` class can be accessed from the API Client.

```csharp
LifestylesController lifestyles = client.Lifestyles;
```

### <a name="create_api_v5_life_styles_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LifestylesController.CreateApiV5LifeStylesPost") CreateApiV5LifeStylesPost

> TODO: Add Description


```csharp
Task CreateApiV5LifeStylesPost(
        string xSessionId,
        string xAuthenticationToken,
        string lifeStyleKey,
        string lifeStyleValue)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| lifeStyleKey |  ``` Required ```  | TODO: Add a parameter description |
| lifeStyleValue |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string lifeStyleKey = "life_style[key]";
string lifeStyleValue = "life_style[value]";

await lifestyles.CreateApiV5LifeStylesPost(xSessionId, xAuthenticationToken, lifeStyleKey, lifeStyleValue);

```


### <a name="update_api_v5_life_styles1615_put"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LifestylesController.UpdateApiV5LifeStyles1615Put") UpdateApiV5LifeStyles1615Put

> TODO: Add Description


```csharp
Task UpdateApiV5LifeStyles1615Put(
        string xSessionId,
        string xAuthenticationToken,
        string lifeStyleKey,
        string lifeStyleValue)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| lifeStyleKey |  ``` Required ```  | TODO: Add a parameter description |
| lifeStyleValue |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string lifeStyleKey = "life_style[key]";
string lifeStyleValue = "life_style[value]";

await lifestyles.UpdateApiV5LifeStyles1615Put(xSessionId, xAuthenticationToken, lifeStyleKey, lifeStyleValue);

```


### <a name="get_api_v5_life_styles_list_life_styles_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LifestylesController.GetApiV5LifeStylesListLifeStylesGet") GetApiV5LifeStylesListLifeStylesGet

> TODO: Add Description


```csharp
Task GetApiV5LifeStylesListLifeStylesGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await lifestyles.GetApiV5LifeStylesListLifeStylesGet(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_life_styles_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LifestylesController.GetApiV5LifeStylesGet") GetApiV5LifeStylesGet

> TODO: Add Description


```csharp
Task GetApiV5LifeStylesGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await lifestyles.GetApiV5LifeStylesGet(xSessionId, xAuthenticationToken);

```


### <a name="delete_api_v5_life_styles1615_delete"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LifestylesController.DeleteApiV5LifeStyles1615Delete") DeleteApiV5LifeStyles1615Delete

> TODO: Add Description


```csharp
Task DeleteApiV5LifeStyles1615Delete(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await lifestyles.DeleteApiV5LifeStyles1615Delete(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="chronic_diseases_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.ChronicDiseasesController") ChronicDiseasesController

### Get singleton instance

The singleton instance of the ``` ChronicDiseasesController ``` class can be accessed from the API Client.

```csharp
ChronicDiseasesController chronicDiseases = client.ChronicDiseases;
```

### <a name="create_api_v5_chronic_diseases_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ChronicDiseasesController.CreateApiV5ChronicDiseasesPost") CreateApiV5ChronicDiseasesPost

> TODO: Add Description


```csharp
Task CreateApiV5ChronicDiseasesPost(
        string xSessionId,
        string xAuthenticationToken,
        string contentType,
        Models.AddnewchronicdiseaseRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string contentType = "Content-Type";
var body = new Models.AddnewchronicdiseaseRequest();

await chronicDiseases.CreateApiV5ChronicDiseasesPost(xSessionId, xAuthenticationToken, contentType, body);

```


### <a name="update_api_v5_chronic_diseases409_put"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ChronicDiseasesController.UpdateApiV5ChronicDiseases409Put") UpdateApiV5ChronicDiseases409Put

> TODO: Add Description


```csharp
Task UpdateApiV5ChronicDiseases409Put(
        string xSessionId,
        string xAuthenticationToken,
        string contentType,
        Models.UpdatechronicdiseaseRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string contentType = "Content-Type";
var body = new Models.UpdatechronicdiseaseRequest();

await chronicDiseases.UpdateApiV5ChronicDiseases409Put(xSessionId, xAuthenticationToken, contentType, body);

```


### <a name="get_api_v5_chronic_diseases_diseases_list_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ChronicDiseasesController.GetApiV5ChronicDiseasesDiseasesListGet") GetApiV5ChronicDiseasesDiseasesListGet

> get static list of chronic diseases names


```csharp
Task GetApiV5ChronicDiseasesDiseasesListGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await chronicDiseases.GetApiV5ChronicDiseasesDiseasesListGet(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_chronic_diseases399_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ChronicDiseasesController.GetApiV5ChronicDiseases399Get") GetApiV5ChronicDiseases399Get

> TODO: Add Description


```csharp
Task GetApiV5ChronicDiseases399Get(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await chronicDiseases.GetApiV5ChronicDiseases399Get(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_chronic_diseases_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ChronicDiseasesController.GetApiV5ChronicDiseasesGet") GetApiV5ChronicDiseasesGet

> TODO: Add Description


```csharp
Task GetApiV5ChronicDiseasesGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await chronicDiseases.GetApiV5ChronicDiseasesGet(xSessionId, xAuthenticationToken);

```


### <a name="delete_api_v5_chronic_diseases409_delete"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ChronicDiseasesController.DeleteApiV5ChronicDiseases409Delete") DeleteApiV5ChronicDiseases409Delete

> TODO: Add Description


```csharp
Task DeleteApiV5ChronicDiseases409Delete(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await chronicDiseases.DeleteApiV5ChronicDiseases409Delete(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="allergies_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.AllergiesController") AllergiesController

### Get singleton instance

The singleton instance of the ``` AllergiesController ``` class can be accessed from the API Client.

```csharp
AllergiesController allergies = client.Allergies;
```

### <a name="create_api_v5_allergies_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.AllergiesController.CreateApiV5AllergiesPost") CreateApiV5AllergiesPost

> TODO: Add Description


```csharp
Task CreateApiV5AllergiesPost(
        string xSessionId,
        string xAuthenticationToken,
        string contentType,
        Models.AddnewallergyRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string contentType = "Content-Type";
var body = new Models.AddnewallergyRequest();

await allergies.CreateApiV5AllergiesPost(xSessionId, xAuthenticationToken, contentType, body);

```


### <a name="update_api_v5_allergies260_put"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.AllergiesController.UpdateApiV5Allergies260Put") UpdateApiV5Allergies260Put

> TODO: Add Description


```csharp
Task UpdateApiV5Allergies260Put(
        string xSessionId,
        string xAuthenticationToken,
        string contentType,
        Models.UpdateallergyRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string contentType = "Content-Type";
var body = new Models.UpdateallergyRequest();

await allergies.UpdateApiV5Allergies260Put(xSessionId, xAuthenticationToken, contentType, body);

```


### <a name="get_api_v5_allergies_autocomplete_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.AllergiesController.GetApiV5AllergiesAutocompleteGet") GetApiV5AllergiesAutocompleteGet

> get static list of chronic diseases names


```csharp
Task GetApiV5AllergiesAutocompleteGet(string term, string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| term |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string term = "term";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await allergies.GetApiV5AllergiesAutocompleteGet(term, xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_allergies255_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.AllergiesController.GetApiV5Allergies255Get") GetApiV5Allergies255Get

> TODO: Add Description


```csharp
Task GetApiV5Allergies255Get(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await allergies.GetApiV5Allergies255Get(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_allergies_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.AllergiesController.GetApiV5AllergiesGet") GetApiV5AllergiesGet

> TODO: Add Description


```csharp
Task GetApiV5AllergiesGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await allergies.GetApiV5AllergiesGet(xSessionId, xAuthenticationToken);

```


### <a name="delete_api_v5_allergies260_delete"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.AllergiesController.DeleteApiV5Allergies260Delete") DeleteApiV5Allergies260Delete

> TODO: Add Description


```csharp
Task DeleteApiV5Allergies260Delete(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await allergies.DeleteApiV5Allergies260Delete(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="individual_images_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.IndividualImagesController") IndividualImagesController

### Get singleton instance

The singleton instance of the ``` IndividualImagesController ``` class can be accessed from the API Client.

```csharp
IndividualImagesController individualImages = client.IndividualImages;
```

### <a name="create_api_v5_individual_images_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.IndividualImagesController.CreateApiV5IndividualImagesPost") CreateApiV5IndividualImagesPost

> TODO: Add Description


```csharp
Task CreateApiV5IndividualImagesPost(
        string xSessionId,
        string xAuthenticationToken,
        string contentType,
        string individualImageImage)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| individualImageImage |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string contentType = "Content-Type";
string individualImageImage = "individual_image[image]";

await individualImages.CreateApiV5IndividualImagesPost(xSessionId, xAuthenticationToken, contentType, individualImageImage);

```


### <a name="get_api_v5_individual_images2_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.IndividualImagesController.GetApiV5IndividualImages2Get") GetApiV5IndividualImages2Get

> TODO: Add Description


```csharp
Task GetApiV5IndividualImages2Get(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await individualImages.GetApiV5IndividualImages2Get(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_individual_images_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.IndividualImagesController.GetApiV5IndividualImagesGet") GetApiV5IndividualImagesGet

> TODO: Add Description


```csharp
Task GetApiV5IndividualImagesGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await individualImages.GetApiV5IndividualImagesGet(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="surgeries_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.SurgeriesController") SurgeriesController

### Get singleton instance

The singleton instance of the ``` SurgeriesController ``` class can be accessed from the API Client.

```csharp
SurgeriesController surgeries = client.Surgeries;
```

### <a name="create_api_v5_surgeries_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.SurgeriesController.CreateApiV5SurgeriesPost") CreateApiV5SurgeriesPost

> TODO: Add Description


```csharp
Task CreateApiV5SurgeriesPost(
        string xSessionId,
        string xAuthenticationToken,
        string contentType,
        Models.AddnewsurgeryRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string contentType = "Content-Type";
var body = new Models.AddnewsurgeryRequest();

await surgeries.CreateApiV5SurgeriesPost(xSessionId, xAuthenticationToken, contentType, body);

```


### <a name="update_api_v5_surgeries300_put"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.SurgeriesController.UpdateApiV5Surgeries300Put") UpdateApiV5Surgeries300Put

> TODO: Add Description


```csharp
Task UpdateApiV5Surgeries300Put(
        string xSessionId,
        string xAuthenticationToken,
        string contentType,
        Models.UpdatesurgeryRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string contentType = "Content-Type";
var body = new Models.UpdatesurgeryRequest();

await surgeries.UpdateApiV5Surgeries300Put(xSessionId, xAuthenticationToken, contentType, body);

```


### <a name="delete_api_v5_surgeries304_delete"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.SurgeriesController.DeleteApiV5Surgeries304Delete") DeleteApiV5Surgeries304Delete

> TODO: Add Description


```csharp
Task DeleteApiV5Surgeries304Delete(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await surgeries.DeleteApiV5Surgeries304Delete(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_surgeries_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.SurgeriesController.GetApiV5SurgeriesGet") GetApiV5SurgeriesGet

> TODO: Add Description


```csharp
Task GetApiV5SurgeriesGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await surgeries.GetApiV5SurgeriesGet(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_surgeries300_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.SurgeriesController.GetApiV5Surgeries300Get") GetApiV5Surgeries300Get

> TODO: Add Description


```csharp
Task GetApiV5Surgeries300Get(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await surgeries.GetApiV5Surgeries300Get(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="measurements_revamp_v5_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.MeasurementsRevampV5Controller") MeasurementsRevampV5Controller

### Get singleton instance

The singleton instance of the ``` MeasurementsRevampV5Controller ``` class can be accessed from the API Client.

```csharp
MeasurementsRevampV5Controller measurementsRevampV5 = client.MeasurementsRevampV5;
```

### <a name="create_api_v5_measurements_weight_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MeasurementsRevampV5Controller.CreateApiV5MeasurementsWeightPost") CreateApiV5MeasurementsWeightPost

> TODO: Add Description


```csharp
Task CreateApiV5MeasurementsWeightPost(
        string xAuthenticationToken,
        string xSessionId,
        string measurementValue,
        string measurementMeasuredDate)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| measurementValue |  ``` Required ```  | TODO: Add a parameter description |
| measurementMeasuredDate |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string measurementValue = "measurement[value]";
string measurementMeasuredDate = "measurement[measured_date]";

await measurementsRevampV5.CreateApiV5MeasurementsWeightPost(xAuthenticationToken, xSessionId, measurementValue, measurementMeasuredDate);

```


### <a name="create_api_v5_measurements_glucose_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MeasurementsRevampV5Controller.CreateApiV5MeasurementsGlucosePost") CreateApiV5MeasurementsGlucosePost

> TODO: Add Description


```csharp
Task CreateApiV5MeasurementsGlucosePost(
        string xAuthenticationToken,
        string xSessionId,
        string measurementValue,
        string measurementMeasuredDate,
        string measurementLastMeal,
        string measurementLastActivity)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| measurementValue |  ``` Required ```  | TODO: Add a parameter description |
| measurementMeasuredDate |  ``` Required ```  | TODO: Add a parameter description |
| measurementLastMeal |  ``` Required ```  | TODO: Add a parameter description |
| measurementLastActivity |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string measurementValue = "measurement[value]";
string measurementMeasuredDate = "measurement[measured_date]";
string measurementLastMeal = "measurement[last_meal]";
string measurementLastActivity = "measurement[last_activity]";

await measurementsRevampV5.CreateApiV5MeasurementsGlucosePost(xAuthenticationToken, xSessionId, measurementValue, measurementMeasuredDate, measurementLastMeal, measurementLastActivity);

```


### <a name="create_api_v5_measurements_blood_pressure_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MeasurementsRevampV5Controller.CreateApiV5MeasurementsBloodPressurePost") CreateApiV5MeasurementsBloodPressurePost

> TODO: Add Description


```csharp
Task CreateApiV5MeasurementsBloodPressurePost(
        string xAuthenticationToken,
        string xSessionId,
        string measurementMeasuredDate,
        string measurementSystolic,
        string measurementDiastolic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| measurementMeasuredDate |  ``` Required ```  | TODO: Add a parameter description |
| measurementSystolic |  ``` Required ```  | TODO: Add a parameter description |
| measurementDiastolic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string measurementMeasuredDate = "measurement[measured_date]";
string measurementSystolic = "measurement[systolic]";
string measurementDiastolic = "measurement[diastolic]";

await measurementsRevampV5.CreateApiV5MeasurementsBloodPressurePost(xAuthenticationToken, xSessionId, measurementMeasuredDate, measurementSystolic, measurementDiastolic);

```


### <a name="get_api_v5_measurements_weight_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MeasurementsRevampV5Controller.GetApiV5MeasurementsWeightGet") GetApiV5MeasurementsWeightGet

> TODO: Add Description


```csharp
Task GetApiV5MeasurementsWeightGet(string measurementIntervalStart, string xAuthenticationToken, string xSessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| measurementIntervalStart |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string measurementIntervalStart = "measurement[interval_start]";
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";

await measurementsRevampV5.GetApiV5MeasurementsWeightGet(measurementIntervalStart, xAuthenticationToken, xSessionId);

```


### <a name="get_api_v5_measurements_glucose_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MeasurementsRevampV5Controller.GetApiV5MeasurementsGlucoseGet") GetApiV5MeasurementsGlucoseGet

> TODO: Add Description


```csharp
Task GetApiV5MeasurementsGlucoseGet(string measurementIntervalStart, string xAuthenticationToken, string xSessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| measurementIntervalStart |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string measurementIntervalStart = "measurement[interval_start]";
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";

await measurementsRevampV5.GetApiV5MeasurementsGlucoseGet(measurementIntervalStart, xAuthenticationToken, xSessionId);

```


### <a name="get_api_v5_measurements_blood_pressure_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MeasurementsRevampV5Controller.GetApiV5MeasurementsBloodPressureGet") GetApiV5MeasurementsBloodPressureGet

> TODO: Add Description


```csharp
Task GetApiV5MeasurementsBloodPressureGet(string measurementIntervalStart, string xAuthenticationToken, string xSessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| measurementIntervalStart |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string measurementIntervalStart = "measurement[interval_start]";
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";

await measurementsRevampV5.GetApiV5MeasurementsBloodPressureGet(measurementIntervalStart, xAuthenticationToken, xSessionId);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="reservation_requests_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.ReservationRequestsController") ReservationRequestsController

### Get singleton instance

The singleton instance of the ``` ReservationRequestsController ``` class can be accessed from the API Client.

```csharp
ReservationRequestsController reservationRequests = client.ReservationRequests;
```

### <a name="create_api_v5_reservation_requests_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ReservationRequestsController.CreateApiV5ReservationRequestsPost") CreateApiV5ReservationRequestsPost

>     Create new reservation request
>     
>   URL: /reservation_requests
>   Method: POST
>   @param doctor_id
>   @param address
>   @param address_details
>   @param mobile_number
>   @param country_code
>   @param patient_latitude
>   @param patient_longitude
>   @param country_code] mobile country code
>   @header [String] X-Authentication-Token
>   @header [String] X-Session-Id
>   @return [JsonArray]  errors  ( code: 422 )


```csharp
Task CreateApiV5ReservationRequestsPost(
        string xSessionId,
        string xAuthenticationToken,
        string doctorId,
        string address,
        string addressDetails,
        string mobileNumber,
        string patientLatitude,
        string patientLongitude)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| doctorId |  ``` Required ```  | TODO: Add a parameter description |
| address |  ``` Required ```  | TODO: Add a parameter description |
| addressDetails |  ``` Required ```  | TODO: Add a parameter description |
| mobileNumber |  ``` Required ```  | TODO: Add a parameter description |
| patientLatitude |  ``` Required ```  | TODO: Add a parameter description |
| patientLongitude |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string doctorId = "doctor_id";
string address = "address";
string addressDetails = "address_details";
string mobileNumber = "mobile_number";
string patientLatitude = "patient_latitude";
string patientLongitude = "patient_longitude";

await reservationRequests.CreateApiV5ReservationRequestsPost(xSessionId, xAuthenticationToken, doctorId, address, addressDetails, mobileNumber, patientLatitude, patientLongitude);

```


### <a name="create_api_v5_reservation_requests2685_ratings_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ReservationRequestsController.CreateApiV5ReservationRequests2685RatingsPost") CreateApiV5ReservationRequests2685RatingsPost

> TODO: Add Description


```csharp
Task CreateApiV5ReservationRequests2685RatingsPost(
        string xAuthenticationToken,
        string xSessionId,
        string ratingStars,
        string ratingReview)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| ratingStars |  ``` Required ```  | TODO: Add a parameter description |
| ratingReview |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication_Token";
string xSessionId = "X-Session_Id";
string ratingStars = "rating[stars]";
string ratingReview = "rating[review]";

await reservationRequests.CreateApiV5ReservationRequests2685RatingsPost(xAuthenticationToken, xSessionId, ratingStars, ratingReview);

```


### <a name="update_api_v5_reservation_requests4142_put"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ReservationRequestsController.UpdateApiV5ReservationRequests4142Put") UpdateApiV5ReservationRequests4142Put

> Doctor reject resesrvation request


```csharp
Task UpdateApiV5ReservationRequests4142Put(string xAuthenticationToken, string xSessionId, string currentStatus)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| currentStatus |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string currentStatus = "current_status";

await reservationRequests.UpdateApiV5ReservationRequests4142Put(xAuthenticationToken, xSessionId, currentStatus);

```


### <a name="create_api_v5_reservation_requests_check_validity_code_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ReservationRequestsController.CreateApiV5ReservationRequestsCheckValidityCodePost") CreateApiV5ReservationRequestsCheckValidityCodePost

> TODO: Add Description


```csharp
Task CreateApiV5ReservationRequestsCheckValidityCodePost(string xSessionId, string xAuthenticationToken, string promoCode)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| promoCode |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-session-id";
string xAuthenticationToken = "X-authentication-token";
string promoCode = "promo_code";

await reservationRequests.CreateApiV5ReservationRequestsCheckValidityCodePost(xSessionId, xAuthenticationToken, promoCode);

```


### <a name="update_api_v5_reservation_requests2668_add_case_info_patch"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ReservationRequestsController.UpdateApiV5ReservationRequests2668AddCaseInfoPatch") UpdateApiV5ReservationRequests2668AddCaseInfoPatch

> TODO: Add Description


```csharp
Task UpdateApiV5ReservationRequests2668AddCaseInfoPatch(string xAuthenticationToken, string xSessionId, string caseInfo)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| caseInfo |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string caseInfo = "case_info";

await reservationRequests.UpdateApiV5ReservationRequests2668AddCaseInfoPatch(xAuthenticationToken, xSessionId, caseInfo);

```


### <a name="get_api_v5_reservation_requests2678_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ReservationRequestsController.GetApiV5ReservationRequests2678Get") GetApiV5ReservationRequests2678Get

>     Create new reservation request
>     
>   URL: /reservation_requests
>   Method: POST
>   @param doctor_id
>   @param address
>   @param address_details
>   @param mobile_number
>   @param country_code
>   @param patient_latitude
>   @param patient_longitude
>   @param country_code] mobile country code
>   @header [String] X-Authentication-Token
>   @header [String] X-Session-Id
>   @return [JsonArray]  errors  ( code: 422 )


```csharp
Task GetApiV5ReservationRequests2678Get(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await reservationRequests.GetApiV5ReservationRequests2678Get(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_reservation_requests2686_show_case_info_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ReservationRequestsController.GetApiV5ReservationRequests2686ShowCaseInfoGet") GetApiV5ReservationRequests2686ShowCaseInfoGet

> TODO: Add Description


```csharp
Task GetApiV5ReservationRequests2686ShowCaseInfoGet(string xAuthenticationToken, string xSessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";

await reservationRequests.GetApiV5ReservationRequests2686ShowCaseInfoGet(xAuthenticationToken, xSessionId);

```


### <a name="get_api_v5_reservation_requests_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ReservationRequestsController.GetApiV5ReservationRequestsGet") GetApiV5ReservationRequestsGet

> TODO: Add Description


```csharp
Task GetApiV5ReservationRequestsGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await reservationRequests.GetApiV5ReservationRequestsGet(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="news_feed_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.NewsFeedController") NewsFeedController

### Get singleton instance

The singleton instance of the ``` NewsFeedController ``` class can be accessed from the API Client.

```csharp
NewsFeedController newsFeed = client.NewsFeed;
```

### <a name="get_api_v5_news574efc7969702d370a130000_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.NewsFeedController.GetApiV5News574efc7969702d370a130000Get") GetApiV5News574efc7969702d370a130000Get

>   -  NewsFeed (news and ads)
>   
>   - The response is paginated - each page contain 10 records
>   
>   - @params [Integer] page (Page number to fetch)
>   - @params [String] lang [ar|en]
>   - @params [comments_count] (will return the number of comments specified , if not specified it will return all comments)
>   
>   - Response:(JsonArray of news feed)
>   
>     - id (sequence id of news feed)
>     - item_type (News or Advertisement)
>     - if item_type is News then you will find news object
>       - id (news id)
>       - title (news title)
>       - cover (news cover image to display in index page)
>       - content_brief (breif content to display in index page)
>       - body (news content body (html))
>       - likes_count
>       - comments_count
>       - share_count
>       - is_liked (indicate user liked this news or not)
>       - saved_link_id (if user saved this news in saved posts   this key will return id of saved link else will return   null)
>       
>     - if item_type is Advertisement you will find advertisement object
>       - id (advertisement id)
>       - content (advertisement content html)
>       - action_tyoe: ["Internal", "External", "Static"]
>          - Internal: This will open internal model.
>          - External: will open URL
>          - Static: nothing to do
>         
>       - menu_action_key (this will used incase of action_type   is Internal): ["Home Care", "Near by Medical Services", "Measurements"]
>       
>       - external_url (in case of action type is external this key will contain url)
>     
>  
>  
>   - This API called if uer authenticated or not  
>   - in case of authenticated user. send required authentication - headers as below:  
>  
>     - X-Authentication-Token  
>     - X-Session-Id


```csharp
Task<dynamic> GetApiV5News574efc7969702d370a130000Get(
        string lang,
        int page,
        int commentsCount,
        string authenticationToken,
        string sessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| lang |  ``` Required ```  | TODO: Add a parameter description |
| page |  ``` Required ```  | TODO: Add a parameter description |
| commentsCount |  ``` Required ```  | TODO: Add a parameter description |
| authenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| sessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string lang = "lang";
int page = 48;
int commentsCount = 48;
string authenticationToken = "authentication_token";
string sessionId = "session_id";

dynamic result = await newsFeed.GetApiV5News574efc7969702d370a130000Get(lang, page, commentsCount, authenticationToken, sessionId);

```


### <a name="get_api_v5_news_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.NewsFeedController.GetApiV5NewsGet") GetApiV5NewsGet

>   -  NewsFeed (news and ads)
>   
>   - The response is paginated - each page contain 10 records
>   
>   - @params [Integer] page (Page number to fetch)
>   - @params [String] lang [ar|en]
>   
>   - Response:(JsonArray of news feed)
>   
>     - id (sequence id of news feed)
>     - item_type (News or Advertisement)
>     - if item_type is News then you will find news object
>       - id (news id)
>       - title (news title)
>       - cover (news cover image to display in index page)
>       - content_brief (breif content to display in index page)
>       - body (news content body (html))
>       - likes_count
>       - comments_count
>       - share_count
>       - is_liked (indicate user liked this news or not)
>       - saved_link_id (if user saved this news in saved posts   this key will return id of saved link else will return   null)
>       - special_tag
>             -id
> 			-name
> 			-icon
> 			-color (hexa)
> 			
>       
>     - if item_type is Advertisement you will find advertisement object
>       - id (advertisement id)
>       - content (advertisement content html)
>       - action_tyoe: ["Internal", "External", "Static"]
>          - Internal: This will open internal model.
>          - External: will open URL
>          - Static: nothing to do
>         
>       - menu_action_key (this will used incase of action_type   is Internal): ["Home Care", "Near by Medical Services", "Measurements"]
>       
>       - external_url (in case of action type is external this key will contain url)
>     
>  
>  
>   - This API called if uer authenticated or not  
>   - in case of authenticated user. send required authentication - headers as below:  
>  
>     - X-Authentication-Token  
>     - X-Session-Id


```csharp
Task<Models.Newssuccess> GetApiV5NewsGet(
        int page,
        int perPage,
        string lang,
        string xAuthenticationToken,
        string xSessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| perPage |  ``` Required ```  | TODO: Add a parameter description |
| lang |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 48;
int perPage = 48;
string lang = "lang";
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";

Models.Newssuccess result = await newsFeed.GetApiV5NewsGet(page, perPage, lang, xAuthenticationToken, xSessionId);

```


### <a name="get_api_v5_news_feeds_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.NewsFeedController.GetApiV5NewsFeedsGet") GetApiV5NewsFeedsGet

>   -  NewsFeed (news and ads)
>   
>   - The response is paginated - each page contain 10 records
>   
>   - @params [Integer] page (Page number to fetch)
>   - @params [String] lang [ar|en]
>   
>   - Response:(JsonArray of news feed)
>   
>     - id (sequence id of news feed)
>     - item_type (News or Advertisement)
>     - if item_type is News then you will find news object
>       - id (news id)
>       - title (news title)
>       - cover (news cover image to display in index page)
>       - content_brief (breif content to display in index page)
>       - body (news content body (html))
>       - likes_count
>       - comments_count
>       - share_count
>       - is_liked (indicate user liked this news or not)
>       - saved_link_id (if user saved this news in saved posts   this key will return id of saved link else will return   null)
>       -special_tag 
> 			-id 
> 			-name
> 			-icon
> 			-color (hexa)
>     - if item_type is Advertisement you will find advertisement object
>       - id (advertisement id)
>       - content_body (advertisement content html)
>       - action_type: ["Internal", "External", "Static"]
>          - Internal: This will open internal model.
>          - External: will open URL
>          - Static: nothing to do
>         
>       - menu_action_key (this will used incase of action_type   is Internal): ["Home Care", "Near by Medical Services", "Measurements"]
>       
>       - external_url (in case of action type is external this key will contain url)
>     
>  
>  
>   - This API called if uer authenticated or not  
>   - in case of authenticated user. send required authentication - headers as below:  
>  
>     - X-Authentication-Token  
>     - X-Session-Id


```csharp
Task GetApiV5NewsFeedsGet(string lang, int page, string newsTagId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| lang |  ``` Required ```  | TODO: Add a parameter description |
| page |  ``` Required ```  | TODO: Add a parameter description |
| newsTagId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string lang = "lang";
int page = 48;
string newsTagId = "news_tag_id";

await newsFeed.GetApiV5NewsFeedsGet(lang, page, newsTagId);

```


### <a name="update_api_v5_news580f73426d61725cae000000_increment_share_count_put"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.NewsFeedController.UpdateApiV5News580f73426d61725cae000000IncrementShareCountPut") UpdateApiV5News580f73426d61725cae000000IncrementShareCountPut

> -This function increments the share counter (initially returns = 0) whenever the user shares a post. 
> -The return variable name is "share_count"
> -To call the count incrementer call the following url news/news_id/increment_share_count?lang=en


```csharp
Task UpdateApiV5News580f73426d61725cae000000IncrementShareCountPut(string lang)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| lang |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string lang = "lang";

await newsFeed.UpdateApiV5News580f73426d61725cae000000IncrementShareCountPut(lang);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="events_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.EventsController") EventsController

### Get singleton instance

The singleton instance of the ``` EventsController ``` class can be accessed from the API Client.

```csharp
EventsController events = client.Events;
```

### <a name="get_api_v5_events_entities_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.EventsController.GetApiV5EventsEntitiesGet") GetApiV5EventsEntitiesGet

> Search for entities that have public events within next 30 days
> params
> 	- page => page number
> 	- per_page => number of rows you need per page, default: 10
> 	- type => the entity type ["Enterprise", "Clinic", "InsuranceCompany", "Hospital", "MedicalCenter", "Ngo", "Lab", "Pharmacy"] 
> 		"this is optional, if not specified it searches for all entity types with no restriction", this is in the url not query, events/:type/...
> 	- entity_name => the name of a specific entity


```csharp
Task GetApiV5EventsEntitiesGet(
        int page,
        string entityName,
        string xSessionId,
        string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| entityName |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 48;
string entityName = "entity_name";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await events.GetApiV5EventsEntitiesGet(page, entityName, xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_events_search_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.EventsController.GetApiV5EventsSearchGet") GetApiV5EventsSearchGet

> Search for entities that have public events within next 30 days
> params
>   - page => page number
>   - per_page => number of rows you need per page, default: 10
>   - type => the entity type ["Enterprise", "Clinic", "InsuranceCompany", "Hospital", "MedicalCenter", "Ngo", "Lab", "Pharmacy"] 
>     "this is optional, if not specified it searches for all entity types with no restriction", this is in the url not query, events/:type/...
>   - entity_name => the name of a specific entity


```csharp
Task GetApiV5EventsSearchGet(int page, string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 48;
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await events.GetApiV5EventsSearchGet(page, xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_events_doctors_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.EventsController.GetApiV5EventsDoctorsGet") GetApiV5EventsDoctorsGet

> Search for doctors that have public events within next 30 days
> 	params
> 		- page => page number 
> 		- per_page => number of rows you need per page, default: 10 
> 		- doctor_name
> 		- doctor_spec
> 		- entity_id
> 		- 
> 		all params are optional, filter by any of them


```csharp
Task GetApiV5EventsDoctorsGet(
        int page,
        int perPage,
        int entityId,
        string doctorName,
        string xSessionId,
        string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| perPage |  ``` Required ```  | TODO: Add a parameter description |
| entityId |  ``` Required ```  | TODO: Add a parameter description |
| doctorName |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 48;
int perPage = 48;
int entityId = 48;
string doctorName = "doctor_name";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await events.GetApiV5EventsDoctorsGet(page, perPage, entityId, doctorName, xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_events_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.EventsController.GetApiV5EventsGet") GetApiV5EventsGet

> TODO: Add Description


```csharp
Task GetApiV5EventsGet(bool dateGrouped, string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| dateGrouped |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
bool dateGrouped = false;
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await events.GetApiV5EventsGet(dateGrouped, xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="nearby_locations_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.NearbyLocationsController") NearbyLocationsController

### Get singleton instance

The singleton instance of the ``` NearbyLocationsController ``` class can be accessed from the API Client.

```csharp
NearbyLocationsController nearbyLocations = client.NearbyLocations;
```

### <a name="get_api_v5_maps_get_type_in_region_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.NearbyLocationsController.GetApiV5MapsGetTypeInRegionGet") GetApiV5MapsGetTypeInRegionGet

> # Specifications :-
> <b>URL : </b>/maps/get_type_in_region  
> <b>Method : </b>GET  
> <b>Description : </b>Auto-complete over the sent substring  
> # Parameters :-
> <b>Headers :</b>  
> 1- X-Authentication-Token  
> 2- X-Session-Id  
> 3- X-App-Id : should be sent only when using doctor app  
> <b>Params :</b>  
> 1- type : clinic or hospital ... etc  
> 2- region_id : region code ... you got it with get_regions action in the first call to api  
> 3- country : country code ... you got it with get_regions action in the first call to api  
> 4- langauge : the langauge in which the results will come with  
> # Response/JSON :-
> { <b>data:</b> array of results for query sent }, <b>status: :ok</b>  
> <b>Every Reply in the array consists of:</b>  
> 1- formatted_address  
> 2- name  
> 3- place_id : unique identifier for that place and could be sent to get datails about that result  
> 4- latitude  
> 5- longitude  
> 6- photo_url  


```csharp
Task GetApiV5MapsGetTypeInRegionGet(
        string type,
        string regionId,
        string country,
        string langauge,
        string xSessionId,
        string xAuthenticationToken,
        string xAppId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| type |  ``` Required ```  | TODO: Add a parameter description |
| regionId |  ``` Required ```  | TODO: Add a parameter description |
| country |  ``` Required ```  | TODO: Add a parameter description |
| langauge |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string type = "type";
string regionId = "region_id";
string country = "country";
string langauge = "langauge";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";

await nearbyLocations.GetApiV5MapsGetTypeInRegionGet(type, regionId, country, langauge, xSessionId, xAuthenticationToken, xAppId);

```


### <a name="get_api_v5_maps_autocomplete_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.NearbyLocationsController.GetApiV5MapsAutocompleteGet") GetApiV5MapsAutocompleteGet

> # Specifications :-
> <b>URL : </b>/maps/autocomplete  
> <b>Method : </b>GET  
> <b>Description : </b>Auto-complete over the sent substring  
> # Parameters :-
> <b>Headers :</b>  
> 1- X-Authentication-Token  
> 2- X-Session-Id  
> 3- X-App-Id : should be sent only when using doctor app  
> <b>Params :</b>  
> 1- input : string you want to auto comlete  
> 2- langauge : the langauge in which the results will come with  
> 3- country : autocomplete will search through places in this cuontry  
> # Response/JSON :-
> { <b>data:</b> array of predictions for the string sent }, <b>status: :ok</b>  
> <b>Every prediction in the array consists of :</b>  
> 1- name : string value for prediction  
> 2- place_id :  unique id of a place to send it to details request  
> 3- types : types specified to the place  


```csharp
Task GetApiV5MapsAutocompleteGet(
        string input,
        string langauge,
        string country,
        string xSessionId,
        string xAuthenticationToken,
        string xAppId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| input |  ``` Required ```  | TODO: Add a parameter description |
| langauge |  ``` Required ```  | TODO: Add a parameter description |
| country |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string input = "input";
string langauge = "langauge";
string country = "country";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";

await nearbyLocations.GetApiV5MapsAutocompleteGet(input, langauge, country, xSessionId, xAuthenticationToken, xAppId);

```


### <a name="get_api_v5_maps_details_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.NearbyLocationsController.GetApiV5MapsDetailsGet") GetApiV5MapsDetailsGet

> # Specifications :-
> <b>URL : </b>/maps/details  
> <b>Method : </b>GET  
> <b>Description : </b>get details about sme place  
> # Parameters :-
> <b>Headers :</b>  
> 1- X-Authentication-Token  
> 2- X-Session-Id  
> 3- X-App-Id : should be sent only when using doctor app  
> <b>Params :</b>  
> 1- id : place id you want to get details about  
> 2- source : currently g for google and f for foursquare cuontry  
> 3- app_id
> # Response/JSON :-
> { <b>data:</b> detailed data about specified place }, <b>status: :ok</b>  
> <b>returned data consists of :</b>  
> 1- formatted_address  
> 2- formatted_phone_number  
> 3- international_phone_number  
> 4- photo_url


```csharp
Task GetApiV5MapsDetailsGet(
        string id,
        string source,
        string appId,
        string xSessionId,
        string xAuthenticationToken,
        string xAppId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | TODO: Add a parameter description |
| source |  ``` Required ```  | TODO: Add a parameter description |
| appId |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string id = "id";
string source = "source";
string appId = "app_id";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";

await nearbyLocations.GetApiV5MapsDetailsGet(id, source, appId, xSessionId, xAuthenticationToken, xAppId);

```


### <a name="get_api_v5_maps_text_search_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.NearbyLocationsController.GetApiV5MapsTextSearchGet") GetApiV5MapsTextSearchGet

> # Specifications :-
> <b>URL : </b>/maps/text_search  
> <b>Method : </b>GET  
> <b>Description : </b>Auto-complete over the sent substring  
> # Parameters :-
> <b>Headers :</b>  
> 1- X-Authentication-Token  
> 2- X-Session-Id  
> 3- X-App-Id : should be sent only when using doctor app  
> <b>Params :</b>  
> 1- query : the search text you want to search about  
> 2- langauge : the langauge in which the results will come with  
> # Response/JSON :-
> { <b>data:</b> array of results for query sent }, <b>status: :ok</b>  
> <b>Every Reply in the array consists of:</b>  
> 1- formatted_address  
> 2- name  
> 3- place_id : unique identifier for that place and could be sent to get datails about that result  
> 4- latitude  
> 5- longitude


```csharp
Task GetApiV5MapsTextSearchGet(
        string query,
        string langauge,
        string xSessionId,
        string xAuthenticationToken,
        string xAppId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| query |  ``` Required ```  | TODO: Add a parameter description |
| langauge |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string query = "query";
string langauge = "langauge";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";

await nearbyLocations.GetApiV5MapsTextSearchGet(query, langauge, xSessionId, xAuthenticationToken, xAppId);

```


### <a name="get_api_v5_maps_photo_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.NearbyLocationsController.GetApiV5MapsPhotoGet") GetApiV5MapsPhotoGet

> # Specifications :-
> <b>URL : </b>/maps/photo  
> <b>Method : </b>GET  
> <b>Description : </b>return photo_url of photo_reference  
> # Parameters :-
> <b>Headers :</b>  
> 1- X-Authentication-Token  
> 2- X-Session-Id  
> 3- X-App-Id : should be sent only when using doctor app  
> <b>Params :</b>  
> 1- photoreference : unique identifier of photo ... usualy comes in search  
> 2- maxwidth : the width you want of the photo  
> # Response/JSON :-
> { <b>data:</b> photo_url }, <b>status: :ok</b>  


```csharp
Task GetApiV5MapsPhotoGet(
        string photoreference,
        string maxwidth,
        string xSessionId,
        string xAuthenticationToken,
        string xAppId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| photoreference |  ``` Required ```  | TODO: Add a parameter description |
| maxwidth |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string photoreference = "photoreference";
string maxwidth = "maxwidth";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";

await nearbyLocations.GetApiV5MapsPhotoGet(photoreference, maxwidth, xSessionId, xAuthenticationToken, xAppId);

```


### <a name="get_api_v5_maps_get_name_of_country_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.NearbyLocationsController.GetApiV5MapsGetNameOfCountryGet") GetApiV5MapsGetNameOfCountryGet

> # Specifications :-
> <b>URL : </b>/maps/get_name_of_country  
> <b>Method : </b>GET  
> <b>Description : </b>return name of country  
> # Parameters :-
> <b>Headers :</b>  
> 1- X-Authentication-Token  
> 2- X-Session-Id  
> 3- X-App-Id : should be sent only when using doctor app  
> <b>Params :</b>  
> 1- latitude  
> 2- longitude  
> # Response/JSON :-
> { <b>data:</b> name of country }, <b>status: :ok</b>  


```csharp
Task GetApiV5MapsGetNameOfCountryGet(
        string latitude,
        string longitude,
        string xSessionId,
        string xAuthenticationToken,
        string xAppId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| latitude |  ``` Required ```  | TODO: Add a parameter description |
| longitude |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string latitude = "latitude";
string longitude = "longitude";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";

await nearbyLocations.GetApiV5MapsGetNameOfCountryGet(latitude, longitude, xSessionId, xAuthenticationToken, xAppId);

```


### <a name="get_api_v5_maps_get_regions_of_country_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.NearbyLocationsController.GetApiV5MapsGetRegionsOfCountryGet") GetApiV5MapsGetRegionsOfCountryGet

> # Specifications :-
> <b>URL : </b>/maps/get_regions_of_country  
> <b>Method : </b>GET  
> <b>Description : </b>return regions of country  
> # Parameters :-
> <b>Headers :</b>  
> 1- X-Authentication-Token  
> 2- X-Session-Id  
> 3- X-App-Id : should be sent only when using doctor app  
> <b>Params :</b>  
> 1- latitude  
> 2- longitude  
> # Response/JSON :-
> { <b>data:</b> {} }, <b>status: :ok</b>  
> data contains hash with iso-code of country and code for each region and its name


```csharp
Task GetApiV5MapsGetRegionsOfCountryGet(
        string latitude,
        string longitude,
        string xSessionId,
        string xAuthenticationToken,
        string xAppId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| latitude |  ``` Required ```  | TODO: Add a parameter description |
| longitude |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string latitude = "latitude";
string longitude = "longitude";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";

await nearbyLocations.GetApiV5MapsGetRegionsOfCountryGet(latitude, longitude, xSessionId, xAuthenticationToken, xAppId);

```


### <a name="get_api_v5_maps_get_regions_and_places_in_country_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.NearbyLocationsController.GetApiV5MapsGetRegionsAndPlacesInCountryGet") GetApiV5MapsGetRegionsAndPlacesInCountryGet

> # Specifications :-
> <b>URL : </b>/maps/get_regions_and_places_in_country  
> <b>Method : </b>GET  
> <b>Description : </b>return regions of country text search with type in that country  
> # Parameters :-
> <b>Headers :</b>  
> 1- X-Authentication-Token  
> 2- X-Session-Id  
> 3- X-App-Id : should be sent only when using doctor app  
> <b>Params :</b>  
> 1- latitude  
> 2- longitude  
> 3- type : clinic or hospital ... etc  
> # Response/JSON :-
> { <b>data:</b> {} }, <b>status: :ok</b>  
> data is the same as get_regions + get_type_in_region


```csharp
Task GetApiV5MapsGetRegionsAndPlacesInCountryGet(
        string latitude,
        string longitude,
        string type,
        string xSessionId,
        string xAuthenticationToken,
        string xAppId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| latitude |  ``` Required ```  | TODO: Add a parameter description |
| longitude |  ``` Required ```  | TODO: Add a parameter description |
| type |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string latitude = "latitude";
string longitude = "longitude";
string type = "type";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";

await nearbyLocations.GetApiV5MapsGetRegionsAndPlacesInCountryGet(latitude, longitude, type, xSessionId, xAuthenticationToken, xAppId);

```


### <a name="get_api_v5_maps_foursquare_plces_search_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.NearbyLocationsController.GetApiV5MapsFoursquarePlcesSearchGet") GetApiV5MapsFoursquarePlcesSearchGet

> # Specifications :-
> <b>URL : </b>/maps/foursquare_plces_search  
> <b>Method : </b>GET  
> # Parameters :-
> <b>Headers :</b>  
> 1- X-Authentication-Token  
> 2- X-Session-Id  
> 3- X-App-Id : should be sent only when using doctor app  
> <b>Params :</b>  
> 1- latitude  
> 2- longitude  
> 3- type : clinic or hospital ... etc  
> # Response/JSON :-
> { <b>data:</b> array of results for query sent }, <b>status: :ok</b>  
> <b>Every Reply in the array consists of:</b>  
> 1- formatted_address  
> 2- name  
> 3- place_id : unique identifier for that place and could be sent to get datails about that result  
> 4- latitude  
> 5- longitude  
> 6- photo_url  


```csharp
Task GetApiV5MapsFoursquarePlcesSearchGet(
        string latitude,
        string longitude,
        string type,
        string xSessionId,
        string xAuthenticationToken,
        string xAppId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| latitude |  ``` Required ```  | TODO: Add a parameter description |
| longitude |  ``` Required ```  | TODO: Add a parameter description |
| type |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string latitude = "latitude";
string longitude = "longitude";
string type = "type";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";

await nearbyLocations.GetApiV5MapsFoursquarePlcesSearchGet(latitude, longitude, type, xSessionId, xAuthenticationToken, xAppId);

```


### <a name="get_api_v5_maps_get_foursquare_photo_url_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.NearbyLocationsController.GetApiV5MapsGetFoursquarePhotoUrlGet") GetApiV5MapsGetFoursquarePhotoUrlGet

> # Specifications :-
> <b>URL : </b>/maps/get_foursquare_photo_url  
> <b>Method : </b>GET  
> <b>Description : </b>return photo_url of photo_reference  
> # Parameters :-
> <b>Headers :</b>  
> 1- X-Authentication-Token  
> 2- X-Session-Id  
> 3- X-App-Id : should be sent only when using doctor app  
> <b>Params :</b>  
> 1- place_id : place id you want to get details about  
> # Response/JSON :-
> { <b>data:</b> photo_url }, <b>status: :ok</b>  


```csharp
Task GetApiV5MapsGetFoursquarePhotoUrlGet(
        string placeId,
        string xSessionId,
        string xAuthenticationToken,
        string xAppId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| placeId |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string placeId = "place_id";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";

await nearbyLocations.GetApiV5MapsGetFoursquarePhotoUrlGet(placeId, xSessionId, xAuthenticationToken, xAppId);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="appointments_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.AppointmentsController") AppointmentsController

### Get singleton instance

The singleton instance of the ``` AppointmentsController ``` class can be accessed from the API Client.

```csharp
AppointmentsController appointments = client.Appointments;
```

### <a name="create_api_v5_appointment_requests_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.AppointmentsController.CreateApiV5AppointmentRequestsPost") CreateApiV5AppointmentRequestsPost

> TODO: Add Description


```csharp
Task CreateApiV5AppointmentRequestsPost(
        string xSessionId,
        string xAuthenticationToken,
        string contentType,
        Models.CreateRequest1 body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string contentType = "Content-Type";
var body = new Models.CreateRequest1();

await appointments.CreateApiV5AppointmentRequestsPost(xSessionId, xAuthenticationToken, contentType, body);

```


### <a name="get_api_v5_appointment_requests_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.AppointmentsController.GetApiV5AppointmentRequestsGet") GetApiV5AppointmentRequestsGet

> TODO: Add Description


```csharp
Task GetApiV5AppointmentRequestsGet(int page, string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 139;
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await appointments.GetApiV5AppointmentRequestsGet(page, xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="session_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.SessionController") SessionController

### Get singleton instance

The singleton instance of the ``` SessionController ``` class can be accessed from the API Client.

```csharp
SessionController session = client.Session;
```

### <a name="create_api_v5_registrations_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.SessionController.CreateApiV5RegistrationsPost") CreateApiV5RegistrationsPost

> sign up by email or mobule number 


```csharp
Task CreateApiV5RegistrationsPost(
        string individualIdentifier,
        string individualFirstName,
        string individualLastName,
        string individualPassword)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| individualIdentifier |  ``` Required ```  | TODO: Add a parameter description |
| individualFirstName |  ``` Required ```  | TODO: Add a parameter description |
| individualLastName |  ``` Required ```  | TODO: Add a parameter description |
| individualPassword |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string individualIdentifier = "individual[identifier]";
string individualFirstName = "individual[first_name]";
string individualLastName = "individual[last_name]";
string individualPassword = "individual[password]";

await session.CreateApiV5RegistrationsPost(individualIdentifier, individualFirstName, individualLastName, individualPassword);

```


### <a name="create_api_v5_sessions_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.SessionController.CreateApiV5SessionsPost") CreateApiV5SessionsPost

> login by email or mobile number 


```csharp
Task<Models.Success> CreateApiV5SessionsPost(string xAppId, string sessionIdentifier, string sessionPassword)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAppId |  ``` Required ```  | TODO: Add a parameter description |
| sessionIdentifier |  ``` Required ```  | nada.magdy+100@nabdacare.com |
| sessionPassword |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAppId = "X-App-Id";
string sessionIdentifier = "session[identifier]";
string sessionPassword = "session[password]";

Models.Success result = await session.CreateApiV5SessionsPost(xAppId, sessionIdentifier, sessionPassword);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | Unauthorized |


### <a name="create_api_v5_sessions_facebook_login_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.SessionController.CreateApiV5SessionsFacebookLoginPost") CreateApiV5SessionsFacebookLoginPost

> TODO: Add Description


```csharp
Task CreateApiV5SessionsFacebookLoginPost(string xFacebookToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xFacebookToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xFacebookToken = "X-Facebook-Token";

await session.CreateApiV5SessionsFacebookLoginPost(xFacebookToken);

```


### <a name="get_api_v5_sessions_get_user_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.SessionController.GetApiV5SessionsGetUserGet") GetApiV5SessionsGetUserGet

> Get individual with more details 
> 1 - reservation_request


```csharp
Task GetApiV5SessionsGetUserGet(string xAuthenticationToken, string xSessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";

await session.GetApiV5SessionsGetUserGet(xAuthenticationToken, xSessionId);

```


### <a name="get_api_v5_sessions_individual_details_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.SessionController.GetApiV5SessionsIndividualDetailsGet") GetApiV5SessionsIndividualDetailsGet

> Get individual with more details 
> 1 - reservation_request


```csharp
Task GetApiV5SessionsIndividualDetailsGet(string xAuthenticationToken, string xSessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";

await session.GetApiV5SessionsIndividualDetailsGet(xAuthenticationToken, xSessionId);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="lab_requests_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.LabRequestsController") LabRequestsController

### Get singleton instance

The singleton instance of the ``` LabRequestsController ``` class can be accessed from the API Client.

```csharp
LabRequestsController labRequests = client.LabRequests;
```

### <a name="get_api_v5_lab_requests_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LabRequestsController.GetApiV5LabRequestsGet") GetApiV5LabRequestsGet

> TODO: Add Description


```csharp
Task GetApiV5LabRequestsGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await labRequests.GetApiV5LabRequestsGet(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_lab_requests515_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LabRequestsController.GetApiV5LabRequests515Get") GetApiV5LabRequests515Get

> TODO: Add Description


```csharp
Task GetApiV5LabRequests515Get(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await labRequests.GetApiV5LabRequests515Get(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_reservation_requests2631_lab_requests_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LabRequestsController.GetApiV5ReservationRequests2631LabRequestsGet") GetApiV5ReservationRequests2631LabRequestsGet

> TODO: Add Description


```csharp
Task GetApiV5ReservationRequests2631LabRequestsGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await labRequests.GetApiV5ReservationRequests2631LabRequestsGet(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_reservation_requests2631_lab_requests535_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LabRequestsController.GetApiV5ReservationRequests2631LabRequests535Get") GetApiV5ReservationRequests2631LabRequests535Get

> TODO: Add Description


```csharp
Task GetApiV5ReservationRequests2631LabRequests535Get(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await labRequests.GetApiV5ReservationRequests2631LabRequests535Get(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="drugs_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.DrugsController") DrugsController

### Get singleton instance

The singleton instance of the ``` DrugsController ``` class can be accessed from the API Client.

```csharp
DrugsController drugs = client.Drugs;
```

### <a name="get_api_v5_drugs_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.DrugsController.GetApiV5DrugsGet") GetApiV5DrugsGet

> TODO: Add Description


```csharp
Task GetApiV5DrugsGet(int active, string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| active |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int active = 139;
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await drugs.GetApiV5DrugsGet(active, xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="places_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.PlacesController") PlacesController

### Get singleton instance

The singleton instance of the ``` PlacesController ``` class can be accessed from the API Client.

```csharp
PlacesController places = client.Places;
```

### <a name="get_api_v5_places_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PlacesController.GetApiV5PlacesGet") GetApiV5PlacesGet

> # URL         => /places
>   # Method      => GET
>   # Description => return regions of country text search with type in that country
>   #==Parameters
>   # headers['X-Authentication-Token']
>   # headers['X-Session-Id']
>   # headers['X-App-Id']
>   # params[:latitude]
>   # params[:longitude]
>   # params[:type] : clinic or hospital ... etc
>   #==Response/JSON
>   # { data: {} }, status: :ok


```csharp
Task GetApiV5PlacesGet(
        double latitude,
        double longitude,
        string type,
        string lang)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| latitude |  ``` Required ```  | TODO: Add a parameter description |
| longitude |  ``` Required ```  | TODO: Add a parameter description |
| type |  ``` Required ```  | TODO: Add a parameter description |
| lang |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double latitude = 139.864344817989;
double longitude = 139.864344817989;
string type = "type";
string lang = "lang";

await places.GetApiV5PlacesGet(latitude, longitude, type, lang);

```


### <a name="get_api_v5_places_categories_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PlacesController.GetApiV5PlacesCategoriesGet") GetApiV5PlacesCategoriesGet

>   # URL         => /places/categories
>   # Method      => GET
>   # Description => return categories
>   #==Parameters
>   # headers['X-Authentication-Token']
>   # headers['X-Session-Id']
>   # headers['X-App-Id']
>   #==Response/JSON
>   # { categories: {} }, status: :ok


```csharp
Task GetApiV5PlacesCategoriesGet(string xSessionId, string xAuthenticationToken, string xAppId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";

await places.GetApiV5PlacesCategoriesGet(xSessionId, xAuthenticationToken, xAppId);

```


### <a name="get_api_v5_places_ch_ijc7w_xvk_ewwbq_ra_u_li_e84_dfe_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PlacesController.GetApiV5PlacesChIJC7wXvkEWWBQRaULiE84DFEGet") GetApiV5PlacesChIJC7wXvkEWWBQRaULiE84DFEGet

> # URL         => /places/id
>   # Method      => GET
>   # Description => get details about some place      
>   #==Parameters
>   # headers['X-Authentication-Token']
>   # headers['X-Session-Id']
>   # headers['X-App-Id']
>   # params[:id] : place id you want to get details about  
>   # params[:source] : currently g for google and f for foursquare
>   # you should add app_id
>   #==Response/JSON
>   # { data: detailed data about specified place }, status: :ok
>   # returned data consists of
>   # formatted_address  
>   # formatted_phone_number
>   # international_phone_number
>   # photo_url : photo_url


```csharp
Task GetApiV5PlacesChIJC7wXvkEWWBQRaULiE84DFEGet(string source, string lang)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| source |  ``` Required ```  | TODO: Add a parameter description |
| lang |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string source = "source";
string lang = "lang";

await places.GetApiV5PlacesChIJC7wXvkEWWBQRaULiE84DFEGet(source, lang);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="doctors_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.DoctorsController") DoctorsController

### Get singleton instance

The singleton instance of the ``` DoctorsController ``` class can be accessed from the API Client.

```csharp
DoctorsController doctors = client.Doctors;
```

### <a name="get_api_v5_doctors_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.DoctorsController.GetApiV5DoctorsGet") GetApiV5DoctorsGet

>   Get Doctors
> 
>   This API by default did'nt include accepted doctor in the response  
> 
>     
>   @params [Float] latitude  
>   @params [Float] longitude  
>   @param  [Integer] speciality_id  
>   @param  [Integer] career_level_id  
>   @return [JsonArray] doctors
>  
>   This API called if uer authenticated or not  
>   in case of authenticated user. send required authentication headers as below:  
>  
>  X-Authentication-Token  
>  X-Session-Id  
>  


```csharp
Task GetApiV5DoctorsGet(
        double latitude,
        double longitude,
        string specialityId,
        string careerLevelId,
        int limit,
        string xAuthenticationToken,
        string xSessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| latitude |  ``` Required ```  | TODO: Add a parameter description |
| longitude |  ``` Required ```  | TODO: Add a parameter description |
| specialityId |  ``` Required ```  | TODO: Add a parameter description |
| careerLevelId |  ``` Required ```  | TODO: Add a parameter description |
| limit |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double latitude = 139.864344817989;
double longitude = 139.864344817989;
string specialityId = "speciality_id";
string careerLevelId = "career_level_id";
int limit = 139;
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";

await doctors.GetApiV5DoctorsGet(latitude, longitude, specialityId, careerLevelId, limit, xAuthenticationToken, xSessionId);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="cross_border_treatments_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.CrossBorderTreatmentsController") CrossBorderTreatmentsController

### Get singleton instance

The singleton instance of the ``` CrossBorderTreatmentsController ``` class can be accessed from the API Client.

```csharp
CrossBorderTreatmentsController crossBorderTreatments = client.CrossBorderTreatments;
```

### <a name="get_api_v5_crm_cross_border_treatment_requests_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.CrossBorderTreatmentsController.GetApiV5CrmCrossBorderTreatmentRequestsGet") GetApiV5CrmCrossBorderTreatmentRequestsGet

> TODO: Add Description


```csharp
Task GetApiV5CrmCrossBorderTreatmentRequestsGet(
        int page,
        int perPage,
        string xAuthenticationToken,
        string xSessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| perPage |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 139;
int perPage = 139;
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";

await crossBorderTreatments.GetApiV5CrmCrossBorderTreatmentRequestsGet(page, perPage, xAuthenticationToken, xSessionId);

```


### <a name="create_api_v5_cross_border_treatment_requests_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.CrossBorderTreatmentsController.CreateApiV5CrossBorderTreatmentRequestsPost") CreateApiV5CrossBorderTreatmentRequestsPost

> TODO: Add Description


```csharp
Task CreateApiV5CrossBorderTreatmentRequestsPost(
        string contentType,
        string crossBorderTreatmentName,
        string crossBorderTreatmentTelephoneNumber,
        string crossBorderTreatmentEmail,
        string crossBorderTreatmentDiagnosis,
        string crossBorderTreatmentTreatmentGroupId,
        string crossBorderTreatmentCountry,
        string crossBorderTreatmentRequestType)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| crossBorderTreatmentName |  ``` Required ```  | TODO: Add a parameter description |
| crossBorderTreatmentTelephoneNumber |  ``` Required ```  | TODO: Add a parameter description |
| crossBorderTreatmentEmail |  ``` Required ```  | TODO: Add a parameter description |
| crossBorderTreatmentDiagnosis |  ``` Required ```  | TODO: Add a parameter description |
| crossBorderTreatmentTreatmentGroupId |  ``` Required ```  | TODO: Add a parameter description |
| crossBorderTreatmentCountry |  ``` Required ```  | TODO: Add a parameter description |
| crossBorderTreatmentRequestType |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string contentType = "Content-Type";
string crossBorderTreatmentName = "cross_border_treatment[name]";
string crossBorderTreatmentTelephoneNumber = "cross_border_treatment[telephone_number]";
string crossBorderTreatmentEmail = "cross_border_treatment[email]";
string crossBorderTreatmentDiagnosis = "cross_border_treatment[diagnosis]";
string crossBorderTreatmentTreatmentGroupId = "cross_border_treatment[treatment_group_id]";
string crossBorderTreatmentCountry = "cross_border_treatment[country]";
string crossBorderTreatmentRequestType = "cross_border_treatment[request_type]";

await crossBorderTreatments.CreateApiV5CrossBorderTreatmentRequestsPost(contentType, crossBorderTreatmentName, crossBorderTreatmentTelephoneNumber, crossBorderTreatmentEmail, crossBorderTreatmentDiagnosis, crossBorderTreatmentTreatmentGroupId, crossBorderTreatmentCountry, crossBorderTreatmentRequestType);

```


### <a name="get_api_v5_cross_border_treatments_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.CrossBorderTreatmentsController.GetApiV5CrossBorderTreatmentsGet") GetApiV5CrossBorderTreatmentsGet

> -params[:type]  can be set as hospital or clinic
>       if not set at all the default is clinics only
> -params[:treatments] comma seperated treatments ids to filter with
> -params[:speciality_id] 
> -params[:country_codes] comma country codes ids to filter with
> -params[:country_code] for old apis to work send 1 country code to filter by
> cross border treatments should be sorted by price


```csharp
Task GetApiV5CrossBorderTreatmentsGet(string type)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| type |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string type = "type";

await crossBorderTreatments.GetApiV5CrossBorderTreatmentsGet(type);

```


### <a name="get_states_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.CrossBorderTreatmentsController.GetStatesGet") GetStatesGet

> TODO: Add Description


```csharp
Task GetStatesGet(string countryCode, string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| countryCode |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string countryCode = "country_code";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await crossBorderTreatments.GetStatesGet(countryCode, xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_cross_border_treatments_countries_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.CrossBorderTreatmentsController.GetApiV5CrossBorderTreatmentsCountriesGet") GetApiV5CrossBorderTreatmentsCountriesGet

> TODO: Add Description


```csharp
Task GetApiV5CrossBorderTreatmentsCountriesGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await crossBorderTreatments.GetApiV5CrossBorderTreatmentsCountriesGet(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_treatments_groups_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.CrossBorderTreatmentsController.GetApiV5TreatmentsGroupsGet") GetApiV5TreatmentsGroupsGet

> TODO: Add Description


```csharp
Task GetApiV5TreatmentsGroupsGet(string lang)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| lang |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string lang = "lang";

await crossBorderTreatments.GetApiV5TreatmentsGroupsGet(lang);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="comments_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.CommentsController") CommentsController

### Get singleton instance

The singleton instance of the ``` CommentsController ``` class can be accessed from the API Client.

```csharp
CommentsController comments = client.Comments;
```

### <a name="get_api_v5_news574efc7969702d370a130000_comments_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.CommentsController.GetApiV5News574efc7969702d370a130000CommentsGet") GetApiV5News574efc7969702d370a130000CommentsGet

> Index comments with pagination 
> params[:page] = page number
> returns all comments
> returns 5 comments per page


```csharp
Task GetApiV5News574efc7969702d370a130000CommentsGet(int page, string xAuthenticationToken, string xSessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 139;
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";

await comments.GetApiV5News574efc7969702d370a130000CommentsGet(page, xAuthenticationToken, xSessionId);

```


### <a name="create_api_v5_news580f73426d61725cae000000_comments_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.CommentsController.CreateApiV5News580f73426d61725cae000000CommentsPost") CreateApiV5News580f73426d61725cae000000CommentsPost

> TODO: Add Description


```csharp
Task CreateApiV5News580f73426d61725cae000000CommentsPost(string xAuthenticationToken, string xSessionId, string commentBody)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| commentBody |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string commentBody = "comment[body]";

await comments.CreateApiV5News580f73426d61725cae000000CommentsPost(xAuthenticationToken, xSessionId, commentBody);

```


### <a name="update_api_v5_news5908b86669702d0d34090000_comments5912e99469702d330f170000_put"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.CommentsController.UpdateApiV5News5908b86669702d0d34090000Comments5912e99469702d330f170000Put") UpdateApiV5News5908b86669702d0d34090000Comments5912e99469702d330f170000Put

> TODO: Add Description


```csharp
Task UpdateApiV5News5908b86669702d0d34090000Comments5912e99469702d330f170000Put(string xAuthenticationToken, string xSessionId, string commentBody)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| commentBody |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string commentBody = "comment[body]";

await comments.UpdateApiV5News5908b86669702d0d34090000Comments5912e99469702d330f170000Put(xAuthenticationToken, xSessionId, commentBody);

```


### <a name="delete_api_v5_news5908b86669702d0d34090000_comments5912e99469702d330f170000_delete"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.CommentsController.DeleteApiV5News5908b86669702d0d34090000Comments5912e99469702d330f170000Delete") DeleteApiV5News5908b86669702d0d34090000Comments5912e99469702d330f170000Delete

> TODO: Add Description


```csharp
Task DeleteApiV5News5908b86669702d0d34090000Comments5912e99469702d330f170000Delete(string xAuthenticationToken, string xSessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";

await comments.DeleteApiV5News5908b86669702d0d34090000Comments5912e99469702d330f170000Delete(xAuthenticationToken, xSessionId);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="paypal_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.PaypalController") PaypalController

### Get singleton instance

The singleton instance of the ``` PaypalController ``` class can be accessed from the API Client.

```csharp
PaypalController paypal = client.Paypal;
```

### <a name="create_token_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PaypalController.CreateTokenPost") CreateTokenPost

> TODO: Add Description


```csharp
Task CreateTokenPost(string contentType, string grantType)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| grantType |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string contentType = "Content-Type";
string grantType = "grant_type";

await paypal.CreateTokenPost(contentType, grantType);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="dicom_mr_es_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.DicomMREsController") DicomMREsController

### Get singleton instance

The singleton instance of the ``` DicomMREsController ``` class can be accessed from the API Client.

```csharp
DicomMREsController dicomMREs = client.DicomMREs;
```

### <a name="get_api_v5_individuals20225_mres_dicom_mres_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.DicomMREsController.GetApiV5Individuals20225MresDicomMresGet") GetApiV5Individuals20225MresDicomMresGet

> TODO: Add Description


```csharp
Task GetApiV5Individuals20225MresDicomMresGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await dicomMREs.GetApiV5Individuals20225MresDicomMresGet(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="video_requests_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.VideoRequestsController") VideoRequestsController

### Get singleton instance

The singleton instance of the ``` VideoRequestsController ``` class can be accessed from the API Client.

```csharp
VideoRequestsController videoRequests = client.VideoRequests;
```

### <a name="create_api_v5_video_requests_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.VideoRequestsController.CreateApiV5VideoRequestsPost") CreateApiV5VideoRequestsPost

>     Create new reservation request
>     
>   URL: /reservation_requests
>   Method: POST
>   @param doctor_id
>   @param address
>   @param address_details
>   @param mobile_number
>   @param country_code
>   @param patient_latitude
>   @param patient_longitude
>   @param country_code] mobile country code
>   @header [String] X-Authentication-Token
>   @header [String] X-Session-Id
>   @return [JsonArray]  errors  ( code: 422 )


```csharp
Task CreateApiV5VideoRequestsPost(
        string xSessionId,
        string xAuthenticationToken,
        string doctorId,
        string howPatientFeels)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| doctorId |  ``` Required ```  | TODO: Add a parameter description |
| howPatientFeels |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string doctorId = "doctor_id";
string howPatientFeels = "how_patient_feels";

await videoRequests.CreateApiV5VideoRequestsPost(xSessionId, xAuthenticationToken, doctorId, howPatientFeels);

```


### <a name="update_api_v5_video_requests755_put"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.VideoRequestsController.UpdateApiV5VideoRequests755Put") UpdateApiV5VideoRequests755Put

> Doctor reject resesrvation request


```csharp
Task UpdateApiV5VideoRequests755Put(
        string xAuthenticationToken,
        string xSessionId,
        string xAppId,
        string currentStatus)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |
| currentStatus |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string xAppId = "X-App-Id";
string currentStatus = "current_status";

await videoRequests.UpdateApiV5VideoRequests755Put(xAuthenticationToken, xSessionId, xAppId, currentStatus);

```


### <a name="create_api_v5_video_requests32_ratings_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.VideoRequestsController.CreateApiV5VideoRequests32RatingsPost") CreateApiV5VideoRequests32RatingsPost

> TODO: Add Description


```csharp
Task CreateApiV5VideoRequests32RatingsPost(
        string xAuthenticationToken,
        string xSessionId,
        string ratingStars,
        string ratingReview)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| ratingStars |  ``` Required ```  | TODO: Add a parameter description |
| ratingReview |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication_Token";
string xSessionId = "X-Session_Id";
string ratingStars = "rating[stars]";
string ratingReview = "rating[review]";

await videoRequests.CreateApiV5VideoRequests32RatingsPost(xAuthenticationToken, xSessionId, ratingStars, ratingReview);

```


### <a name="create_api_v5_video_requests_check_validity_code_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.VideoRequestsController.CreateApiV5VideoRequestsCheckValidityCodePost") CreateApiV5VideoRequestsCheckValidityCodePost

> TODO: Add Description


```csharp
Task CreateApiV5VideoRequestsCheckValidityCodePost(string xSessionId, string xAuthenticationToken, string promoCode)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| promoCode |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-session-id";
string xAuthenticationToken = "X-authentication-token";
string promoCode = "promo_code";

await videoRequests.CreateApiV5VideoRequestsCheckValidityCodePost(xSessionId, xAuthenticationToken, promoCode);

```


### <a name="update_api_v5_video_requests2668_add_case_info_patch"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.VideoRequestsController.UpdateApiV5VideoRequests2668AddCaseInfoPatch") UpdateApiV5VideoRequests2668AddCaseInfoPatch

> TODO: Add Description


```csharp
Task UpdateApiV5VideoRequests2668AddCaseInfoPatch(string xAuthenticationToken, string xSessionId, string caseInfo)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| caseInfo |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string caseInfo = "case_info";

await videoRequests.UpdateApiV5VideoRequests2668AddCaseInfoPatch(xAuthenticationToken, xSessionId, caseInfo);

```


### <a name="get_api_v5_video_requests28_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.VideoRequestsController.GetApiV5VideoRequests28Get") GetApiV5VideoRequests28Get

>     Create new reservation request
>     
>   URL: /video_requests
>   Method: POST
>   @param doctor_id
>   @param address
>   @param address_details
>   @param mobile_number
>   @param country_code
>   @param patient_latitude
>   @param patient_longitude
>   @param country_code] mobile country code
>   @header [String] X-Authentication-Token
>   @header [String] X-Session-Id
>   @return [JsonArray]  errors  ( code: 422 )


```csharp
Task GetApiV5VideoRequests28Get(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await videoRequests.GetApiV5VideoRequests28Get(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_doctors_with_relations_embeded_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.VideoRequestsController.GetApiV5DoctorsWithRelationsEmbededGet") GetApiV5DoctorsWithRelationsEmbededGet

> speciality_id&career_level_id


```csharp
Task GetApiV5DoctorsWithRelationsEmbededGet(string type, string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| type |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string type = "type";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await videoRequests.GetApiV5DoctorsWithRelationsEmbededGet(type, xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_conference_rooms54141_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.VideoRequestsController.GetApiV5ConferenceRooms54141Get") GetApiV5ConferenceRooms54141Get

> TODO: Add Description


```csharp
Task GetApiV5ConferenceRooms54141Get(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await videoRequests.GetApiV5ConferenceRooms54141Get(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_video_requests31_show_case_info_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.VideoRequestsController.GetApiV5VideoRequests31ShowCaseInfoGet") GetApiV5VideoRequests31ShowCaseInfoGet

> TODO: Add Description


```csharp
Task GetApiV5VideoRequests31ShowCaseInfoGet(string xAuthenticationToken, string xSessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";

await videoRequests.GetApiV5VideoRequests31ShowCaseInfoGet(xAuthenticationToken, xSessionId);

```


### <a name="update_api_v5_video_requests72_put"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.VideoRequestsController.UpdateApiV5VideoRequests72Put") UpdateApiV5VideoRequests72Put

> increment intervals count


```csharp
Task UpdateApiV5VideoRequests72Put(string xAuthenticationToken, string xSessionId, string currentStatus)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| currentStatus |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string currentStatus = "current_status";

await videoRequests.UpdateApiV5VideoRequests72Put(xAuthenticationToken, xSessionId, currentStatus);

```


### <a name="get_api_v5_video_requests_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.VideoRequestsController.GetApiV5VideoRequestsGet") GetApiV5VideoRequestsGet

> TODO: Add Description


```csharp
Task GetApiV5VideoRequestsGet(string status, string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| status |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string status = "status";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await videoRequests.GetApiV5VideoRequestsGet(status, xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="prescription_images_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.PrescriptionImagesController") PrescriptionImagesController

### Get singleton instance

The singleton instance of the ``` PrescriptionImagesController ``` class can be accessed from the API Client.

```csharp
PrescriptionImagesController prescriptionImages = client.PrescriptionImages;
```

### <a name="get_api_v5_prescription_images_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PrescriptionImagesController.GetApiV5PrescriptionImagesGet") GetApiV5PrescriptionImagesGet

> TODO: Add Description


```csharp
Task GetApiV5PrescriptionImagesGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await prescriptionImages.GetApiV5PrescriptionImagesGet(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_prescription_images58d23b9b5461720ee2000000_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PrescriptionImagesController.GetApiV5PrescriptionImages58d23b9b5461720ee2000000Get") GetApiV5PrescriptionImages58d23b9b5461720ee2000000Get

> TODO: Add Description


```csharp
Task GetApiV5PrescriptionImages58d23b9b5461720ee2000000Get(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await prescriptionImages.GetApiV5PrescriptionImages58d23b9b5461720ee2000000Get(xSessionId, xAuthenticationToken);

```


### <a name="create_api_v5_reservation_requests2668_prescription_images_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PrescriptionImagesController.CreateApiV5ReservationRequests2668PrescriptionImagesPost") CreateApiV5ReservationRequests2668PrescriptionImagesPost

> TODO: Add Description


```csharp
Task CreateApiV5ReservationRequests2668PrescriptionImagesPost(string xSessionId, string xAuthenticationToken, string prescriptionImageImage)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| prescriptionImageImage |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string prescriptionImageImage = "prescription_image[image]";

await prescriptionImages.CreateApiV5ReservationRequests2668PrescriptionImagesPost(xSessionId, xAuthenticationToken, prescriptionImageImage);

```


### <a name="get_api_v5_reservation_requests2668_prescription_images_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.PrescriptionImagesController.GetApiV5ReservationRequests2668PrescriptionImagesGet") GetApiV5ReservationRequests2668PrescriptionImagesGet

> TODO: Add Description


```csharp
Task GetApiV5ReservationRequests2668PrescriptionImagesGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await prescriptionImages.GetApiV5ReservationRequests2668PrescriptionImagesGet(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="likes_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.LikesController") LikesController

### Get singleton instance

The singleton instance of the ``` LikesController ``` class can be accessed from the API Client.

```csharp
LikesController likes = client.Likes;
```

### <a name="create_api_v5_news57e3b4f769702d1ae60b0000_likes_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LikesController.CreateApiV5News57e3b4f769702d1ae60b0000LikesPost") CreateApiV5News57e3b4f769702d1ae60b0000LikesPost

> TODO: Add Description


```csharp
Task CreateApiV5News57e3b4f769702d1ae60b0000LikesPost(string xAuthenticationToken, string xSessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";

await likes.CreateApiV5News57e3b4f769702d1ae60b0000LikesPost(xAuthenticationToken, xSessionId);

```


### <a name="delete_api_v5_news57e3b4f769702d1ae60b0000_likes_destroy_like_delete"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LikesController.DeleteApiV5News57e3b4f769702d1ae60b0000LikesDestroyLikeDelete") DeleteApiV5News57e3b4f769702d1ae60b0000LikesDestroyLikeDelete

> TODO: Add Description


```csharp
Task DeleteApiV5News57e3b4f769702d1ae60b0000LikesDestroyLikeDelete(string xAuthenticationToken, string xSessionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";

await likes.DeleteApiV5News57e3b4f769702d1ae60b0000LikesDestroyLikeDelete(xAuthenticationToken, xSessionId);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="video_extension_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.VideoExtensionController") VideoExtensionController

### Get singleton instance

The singleton instance of the ``` VideoExtensionController ``` class can be accessed from the API Client.

```csharp
VideoExtensionController videoExtension = client.VideoExtension;
```

### <a name="create_api_v5_video_extensions_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.VideoExtensionController.CreateApiV5VideoExtensionsPost") CreateApiV5VideoExtensionsPost

> TODO: Add Description


```csharp
Task CreateApiV5VideoExtensionsPost(
        string xAuthenticationToken,
        string xSessionId,
        string contentType,
        Models.CreateRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string contentType = "Content-Type";
var body = new Models.CreateRequest();

await videoExtension.CreateApiV5VideoExtensionsPost(xAuthenticationToken, xSessionId, contentType, body);

```


### <a name="get_api_v5_video_extensions76_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.VideoExtensionController.GetApiV5VideoExtensions76Get") GetApiV5VideoExtensions76Get

> TODO: Add Description


```csharp
Task GetApiV5VideoExtensions76Get(string xAuthenticationToken, string xSessionId, string contentType)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| contentType |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string contentType = "Content-Type";

await videoExtension.GetApiV5VideoExtensions76Get(xAuthenticationToken, xSessionId, contentType);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="edit_profile_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.EditProfileController") EditProfileController

### Get singleton instance

The singleton instance of the ``` EditProfileController ``` class can be accessed from the API Client.

```csharp
EditProfileController editProfile = client.EditProfile;
```

### <a name="update_api_v5_update_profile_patch"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.EditProfileController.UpdateApiV5UpdateProfilePatch") UpdateApiV5UpdateProfilePatch

> TODO: Add Description


```csharp
Task UpdateApiV5UpdateProfilePatch(
        string xAuthenticationToken,
        string xSessionId,
        string individualFirstName,
        string individualLastName,
        string individualAvatar,
        string individualAddressStreet,
        string individualAddressBuilding,
        string individualAddressCity,
        string individualAddressCountry)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| individualFirstName |  ``` Required ```  | TODO: Add a parameter description |
| individualLastName |  ``` Required ```  | TODO: Add a parameter description |
| individualAvatar |  ``` Required ```  | TODO: Add a parameter description |
| individualAddressStreet |  ``` Required ```  | TODO: Add a parameter description |
| individualAddressBuilding |  ``` Required ```  | TODO: Add a parameter description |
| individualAddressCity |  ``` Required ```  | TODO: Add a parameter description |
| individualAddressCountry |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string individualFirstName = "individual[first_name]";
string individualLastName = "individual[last_name]";
string individualAvatar = "individual[avatar]";
string individualAddressStreet = "individual[address[street]]";
string individualAddressBuilding = "individual[address[building]]";
string individualAddressCity = "individual[address[city]]";
string individualAddressCountry = "individual[address[country]]";

await editProfile.UpdateApiV5UpdateProfilePatch(xAuthenticationToken, xSessionId, individualFirstName, individualLastName, individualAvatar, individualAddressStreet, individualAddressBuilding, individualAddressCity, individualAddressCountry);

```


### <a name="create_api_v5_individuals_edit_identifier_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.EditProfileController.CreateApiV5IndividualsEditIdentifierPost") CreateApiV5IndividualsEditIdentifierPost

> first step to edit .. 
> sends confirmation and save it in the cache


```csharp
Task CreateApiV5IndividualsEditIdentifierPost(
        string xAuthenticationToken,
        string xSessionId,
        string identifier,
        string type)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| identifier |  ``` Required ```  | TODO: Add a parameter description |
| type |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string identifier = "identifier";
string type = "type";

await editProfile.CreateApiV5IndividualsEditIdentifierPost(xAuthenticationToken, xSessionId, identifier, type);

```


### <a name="create_api_v5_individuals_update_identifier_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.EditProfileController.CreateApiV5IndividualsUpdateIdentifierPost") CreateApiV5IndividualsUpdateIdentifierPost

> final step to confirm the update ..
> 


```csharp
Task CreateApiV5IndividualsUpdateIdentifierPost(
        string xAuthenticationToken,
        string xSessionId,
        string identifier,
        string confirmationCode,
        string type)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| identifier |  ``` Required ```  | TODO: Add a parameter description |
| confirmationCode |  ``` Required ```  | TODO: Add a parameter description |
| type |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xAuthenticationToken = "X-Authentication-Token";
string xSessionId = "X-Session-Id";
string identifier = "identifier";
string confirmationCode = "confirmation_code";
string type = "type";

await editProfile.CreateApiV5IndividualsUpdateIdentifierPost(xAuthenticationToken, xSessionId, identifier, confirmationCode, type);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="advertisements_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.AdvertisementsController") AdvertisementsController

### Get singleton instance

The singleton instance of the ``` AdvertisementsController ``` class can be accessed from the API Client.

```csharp
AdvertisementsController advertisements = client.Advertisements;
```

### <a name="get_api_v5_advertisements_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.AdvertisementsController.GetApiV5AdvertisementsGet") GetApiV5AdvertisementsGet

> TODO: Add Description


```csharp
Task GetApiV5AdvertisementsGet(string advertisementPage)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| advertisementPage |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string advertisementPage = "advertisement_page";

await advertisements.GetApiV5AdvertisementsGet(advertisementPage);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="reset_password_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.ResetPasswordController") ResetPasswordController

### Get singleton instance

The singleton instance of the ``` ResetPasswordController ``` class can be accessed from the API Client.

```csharp
ResetPasswordController resetPassword = client.ResetPassword;
```

### <a name="create_api_v5_reset_passwords_send_reset_password_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ResetPasswordController.CreateApiV5ResetPasswordsSendResetPasswordPost") CreateApiV5ResetPasswordsSendResetPasswordPost

> TODO: Add Description


```csharp
Task CreateApiV5ResetPasswordsSendResetPasswordPost(string receiver)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| receiver |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string receiver = "receiver";

await resetPassword.CreateApiV5ResetPasswordsSendResetPasswordPost(receiver);

```


### <a name="create_api_v5_reset_passwords_reset_password_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ResetPasswordController.CreateApiV5ResetPasswordsResetPasswordPost") CreateApiV5ResetPasswordsResetPasswordPost

> TODO: Add Description


```csharp
Task CreateApiV5ResetPasswordsResetPasswordPost(string receiver, string token, string password)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| receiver |  ``` Required ```  | TODO: Add a parameter description |
| token |  ``` Required ```  | TODO: Add a parameter description |
| password |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string receiver = "receiver";
string token = "token";
string password = "password";

await resetPassword.CreateApiV5ResetPasswordsResetPasswordPost(receiver, token, password);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="messages_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.MessagesController") MessagesController

### Get singleton instance

The singleton instance of the ``` MessagesController ``` class can be accessed from the API Client.

```csharp
MessagesController messages = client.Messages;
```

### <a name="get_api_v5_messages_get_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MessagesController.GetApiV5MessagesGetGet") GetApiV5MessagesGetGet

>  # URL         => /messages/get
>   # Method      => GET
>   # Description => Get List of Messages
>   #==Parameters
>   # range => represent the number of messages per page (default => 500)
>   # page  => page number (default => 1)
>   # email => curent user email
>   # authentication_token => curent user authentication_token (you get this token after login/registration)
>   #==Response/JSON
>   # {success: true , messages: array_of_messages}
>   # Every message in the array consists of:
>   # 1. date    => last reply date (Or message creation date if no replies)
>   # 2. date_unix_timestamp
>   # 3. id      => message id
>   # 4. title   => message title
>   # 5. is_seen => 1/0
>   # 6. is_sent => 1/0
>   # 7. Array_of_Users
>   #   Every user in the array consists of:
>   #     1. first_name
>   #     2. id
>   #     3. avatar => Object
>   #           {url: value , icon: {url: value},thumb: {url: value}, profile: {url: value}, profile_big: {url: value} }
>   # 8. last_reply => last reply on the message
>   #
>   # NOTE: In case of error response will be => {sucess: false , code: error_code , message: error_message }
>   # Errors:
>   #   1. UnauthorizedAccessError ( code: 401 )


```csharp
Task GetApiV5MessagesGetGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await messages.GetApiV5MessagesGetGet(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_messages_get_replies_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MessagesController.GetApiV5MessagesGetRepliesGet") GetApiV5MessagesGetRepliesGet

>  # URL         => /messages/get_replies
>   # Method      => GET
>   # Description => Get List of Message Replies
>   #==Parameters
>   # range      => represent the number of replies per page (default => 500)
>   # page       => page number (default => 1)
>   # message_id => id of the messages which the required replies belongs to
>   # email      => curent user email
>   # authentication_token => curent user authentication_token (you get this token after login/registration)
>   #==Response/JSON
>   # {success: true , replies: array_of_replies}
>   # array_of_replies => including the 'message' itself
>   # Every Reply in the array consists of:
>   # 1. date    => creation date
>   # 2. date_unix_timestamp
>   # 3. body    => reply/message content
>   # 4. id
>   # 5. user    => owner of the current reply/message
>   #     Object consists of:
>   #     1. full_name
>   #     2. id
>   #     3. avatar => Object
>   #           {url: value , icon: {url: value},thumb: {url: value}, profile: {url: value}, profile_big: {url: value} }
>   #
>   # NOTE: In case of error response will be => {sucess: false , code: error_code , message: error_message }
>   # Errors:
>   #   1. UnauthorizedAccessError ( code: 401 )
>   #   2. BadRequestError ( code: 400 )
>   #   3. NotFoundError   ( code: 404 )


```csharp
Task GetApiV5MessagesGetRepliesGet(int messageId, string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageId |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int messageId = 98;
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await messages.GetApiV5MessagesGetRepliesGet(messageId, xSessionId, xAuthenticationToken);

```


### <a name="create_api_v5_messages_send_message_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MessagesController.CreateApiV5MessagesSendMessagePost") CreateApiV5MessagesSendMessagePost

> # URL         => /messages/send_message
>   # Method      => POST
>   #==Parameters
>   # title
>   # body
>   # users_ids  => comma seperated ids of the receivers (ex: 256,10365)
>   # email      => curent user email
>   # authentication_token => curent user authentication_token (you get this token after login/registration)
>   #==Response/JSON
>   # { success: true }
>   #
>   # NOTE: In case of error response will be => {sucess: false , code: error_code , message: error_message }
>   # Errors:
>   #   1. UnauthorizedAccessError ( code: 401 )
>   #   2. BadRequestError         ( code: 400 )
>   #==Description
>   # this function send message to required receiver, in case many receivers => a different message
>   # will be created for each receiver (one to one)


```csharp
Task CreateApiV5MessagesSendMessagePost(
        string xSessionId,
        string xAuthenticationToken,
        string title,
        string body,
        string usersIds,
        string attachment)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| title |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |
| usersIds |  ``` Required ```  | TODO: Add a parameter description |
| attachment |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string title = "title";
string body = "body";
string usersIds = "users_ids";
string attachment = "attachment";

await messages.CreateApiV5MessagesSendMessagePost(xSessionId, xAuthenticationToken, title, body, usersIds, attachment);

```


### <a name="create_api_v5_messages_send_reply_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MessagesController.CreateApiV5MessagesSendReplyPost") CreateApiV5MessagesSendReplyPost

> # URL       => /messages/send_reply
>   # Method    => POST
>   #==Parameters
>   # body       => reply content
>   # message_id => send reply to the message with that ID
>   # email      => curent user email
>   # authentication_token => curent user authentication_token (you get this token after login/registration)
>   #==Response/JSON
>   # { success: true }
>   #
>   # NOTE: In case of error response will be => {sucess: false , code: error_code , message: error_message }
>   # Errors:
>   #   1. UnauthorizedAccessError ( code: 401 )
>   #   2. BadRequestError         ( code: 400 )
>   #   3. ForbiddenError          ( code: 403 )


```csharp
Task CreateApiV5MessagesSendReplyPost(
        string xSessionId,
        string xAuthenticationToken,
        string body,
        string messageId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |
| messageId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string body = "body";
string messageId = "message_id";

await messages.CreateApiV5MessagesSendReplyPost(xSessionId, xAuthenticationToken, body, messageId);

```


### <a name="get_api_v5_messages_search_users_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MessagesController.GetApiV5MessagesSearchUsersGet") GetApiV5MessagesSearchUsersGet

>  # URL         => /messages/search_users
>   # Method      => GET
>   # Description => Search for the users which you are able to send them messages
>   #                Staff to Staff and patients
>   #                Patients to Doctors
>   #                Doctors to Patients which have PMR access on them and vice versa
>   #==Parameters
>   # term  => search for a user with name contains this term/pattern
>   # range => (Optional) default range is 10
>   # email => curent user email
>   # authentication_token => curent user authentication_token (you get this token after login/registration)
>   #==Response/JSON
>   # {success: true , messages: array_of_users}
>   # Every user in the array consists of:
>   # 1. full_name    => user full name
>   # 2. id           => user id
>   # 3. avatar       => user images urls/ with different sizes
>   #     Object consists of:
>   #       {url: value , icon: {url: value},thumb: {url: value}, profile: {url: value}, profile_big: {url: value} }
>   #
>   # NOTE: In case of error response will be => {sucess: false , code: error_code , message: error_message }
>   # Errors:
>   #   1. UnauthorizedAccessError ( code: 401 )
>   #   2. BadRequestError         ( code: 400 )


```csharp
Task GetApiV5MessagesSearchUsersGet(string term, string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| term |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string term = "term";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await messages.GetApiV5MessagesSearchUsersGet(term, xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="lab_request_images_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.LabRequestImagesController") LabRequestImagesController

### Get singleton instance

The singleton instance of the ``` LabRequestImagesController ``` class can be accessed from the API Client.

```csharp
LabRequestImagesController labRequestImages = client.LabRequestImages;
```

### <a name="get_api_v5_lab_request_images_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LabRequestImagesController.GetApiV5LabRequestImagesGet") GetApiV5LabRequestImagesGet

> TODO: Add Description


```csharp
Task GetApiV5LabRequestImagesGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await labRequestImages.GetApiV5LabRequestImagesGet(xSessionId, xAuthenticationToken);

```


### <a name="get_api_v5_lab_request_images58d23b9b5461720ee2000000_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LabRequestImagesController.GetApiV5LabRequestImages58d23b9b5461720ee2000000Get") GetApiV5LabRequestImages58d23b9b5461720ee2000000Get

> TODO: Add Description


```csharp
Task GetApiV5LabRequestImages58d23b9b5461720ee2000000Get(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await labRequestImages.GetApiV5LabRequestImages58d23b9b5461720ee2000000Get(xSessionId, xAuthenticationToken);

```


### <a name="create_api_v5_reservation_requests3756_lab_request_images_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LabRequestImagesController.CreateApiV5ReservationRequests3756LabRequestImagesPost") CreateApiV5ReservationRequests3756LabRequestImagesPost

> TODO: Add Description


```csharp
Task CreateApiV5ReservationRequests3756LabRequestImagesPost(string xSessionId, string xAuthenticationToken, string labRequestImageImage)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| labRequestImageImage |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string labRequestImageImage = "lab_request_image[image]";

await labRequestImages.CreateApiV5ReservationRequests3756LabRequestImagesPost(xSessionId, xAuthenticationToken, labRequestImageImage);

```


### <a name="get_api_v5_reservation_requests3827_lab_request_images_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.LabRequestImagesController.GetApiV5ReservationRequests3827LabRequestImagesGet") GetApiV5ReservationRequests3827LabRequestImagesGet

> TODO: Add Description


```csharp
Task GetApiV5ReservationRequests3827LabRequestImagesGet(string xSessionId, string xAuthenticationToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";

await labRequestImages.GetApiV5ReservationRequests3827LabRequestImagesGet(xSessionId, xAuthenticationToken);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="measurements_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.MeasurementsController") MeasurementsController

### Get singleton instance

The singleton instance of the ``` MeasurementsController ``` class can be accessed from the API Client.

```csharp
MeasurementsController measurements = client.Measurements;
```

### <a name="create_api_v5_diabetes_add_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MeasurementsController.CreateApiV5DiabetesAddPost") CreateApiV5DiabetesAddPost

> # Specifications :-
> <b>URL : </b>/diabetes/add  
> <b>Method : </b>POST  
> # Parameters :-
> <b>Headers :</b>  
> 1- X-Authentication-Token  
> 2- X-Session-Id  
> 3- X-App-Id : should be sent only when using doctor app  
> <b>Params :</b>  
> -diabetes : String contains fields data in json (array) format  
> Ex: "[{ 'field_name': "" }]" --> string "[]" not json object/array  
> 
> Each Object in the array consists of:  
> 1- field_name  
> 2- field_value  
> 3- date Or date_timestamp (with date_timestamp you don't need to send date field again in the relations array)  
> 4- relations => Array_of_relations  
> Every relation in the array consists of the same previous attributes/keys  
> ( date, field_name, field_value )  
> <b>Note in Pregnancy App</b>  
> "field_name" param possible values are => glucose, blood_pressure, weight  
> When the "field_name" value is glucose then the "field_name" value inside the relations will be  => "last meal", "activity"  
> The "last meal" "field_value" could be => Before Breakfast, After Breakfast, Before Lunch, After Lunch, At Fasting  
> The "activity"  "field_value" could be => No exercise, Light, Moderate, Heavy  
> # Response/JSON :-
> 1- {}, status: :ok  
> 2- {}, status: :unprocessable_entity


```csharp
Task CreateApiV5DiabetesAddPost(
        string diabetes,
        string xSessionId,
        string xAuthenticationToken,
        string xAppId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| diabetes |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string diabetes = "diabetes";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";

await measurements.CreateApiV5DiabetesAddPost(diabetes, xSessionId, xAuthenticationToken, xAppId);

```


### <a name="get_api_v5_diabetes_get_summary_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MeasurementsController.GetApiV5DiabetesGetSummaryGet") GetApiV5DiabetesGetSummaryGet

> # Specifications :-
> <b>URL : </b>/diabetes/get_summary  
> <b>Method : </b>GET  
> # Parameters :-
> <b>Headers :</b>  
> 1- X-Authentication-Token  
> 2- X-Session-Id  
> 3- X-App-Id : should be sent only when using doctor app  
> # Response/JSON :-
> 1- <b>{measurements: Array_of_values}, status: :ok</b>  
> &nbsp;&nbsp;Every Value in the array (sorted by date) consists of:  
> &nbsp;&nbsp;1- created_at  
> &nbsp;&nbsp;2- date  
> &nbsp;&nbsp;3- date_timestamp  
> &nbsp;&nbsp;4- field_name  
> &nbsp;&nbsp;5- field_value  
> &nbsp;&nbsp;6- id  
> &nbsp;&nbsp;7- is_pmr  
> &nbsp;&nbsp;8- updated_at  
> &nbsp;&nbsp;9- user_id  
> &nbsp;&nbsp;10- relations   => Array_of_relations  
> &nbsp;&nbsp;&nbsp;&nbsp;Every relation in the array consists of the same previous attributes/keys  
> &nbsp;&nbsp;&nbsp;&nbsp;( created_at, date, field_name, field_value, id, is_pmr, updated_at, user_id )  
> 2- <b>{}, status: :unprocessable_entity</b>


```csharp
Task GetApiV5DiabetesGetSummaryGet(string xSessionId, string xAuthenticationToken, string xAppId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";

await measurements.GetApiV5DiabetesGetSummaryGet(xSessionId, xAuthenticationToken, xAppId);

```


### <a name="get_api_v5_diabetes_get_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MeasurementsController.GetApiV5DiabetesGetGet") GetApiV5DiabetesGetGet

> # Specifications :-
> <b>URL : </b>/diabetes/get  
> <b>Method : </b>GET  
> <b>Description : </b>retrieve the corresponding diabetes info to the provided user with the diabetes type and build back the relations if it exists  
> # Parameters :-
> <b>Headers :</b>  
> 1- X-Authentication-Token  
> 2- X-Session-Id  
> 3- X-App-Id : should be sent only when using doctor app  
> <b>Params :</b>  
> 1- type  
> <b>Note in Pregnancy App</b>  
> "type" param possible values are => glucose, blood_pressure, weight
> # Response/JSON :-
> 1- <b>{measurements: Array_of_values}, status: :ok</b>  
> &nbsp;&nbsp;Every Value in the array (sorted by date) consists of:  
> &nbsp;&nbsp;1- created_at  
> &nbsp;&nbsp;2- date  
> &nbsp;&nbsp;3- date_timestamp  
> &nbsp;&nbsp;4- field_name  
> &nbsp;&nbsp;5- field_value  
> &nbsp;&nbsp;6- id  
> &nbsp;&nbsp;7- is_pmr  
> &nbsp;&nbsp;8- updated_at  
> &nbsp;&nbsp;9- user_id  
> &nbsp;&nbsp;10- relations   => Array_of_relations  
> &nbsp;&nbsp;&nbsp;&nbsp;Every relation in the array consists of the same previous attributes/keys  
> &nbsp;&nbsp;&nbsp;&nbsp;( created_at, date, field_name, field_value, id, is_pmr, updated_at, user_id )  
> 2- <b>{}, status: :unprocessable_entity</b>


```csharp
Task GetApiV5DiabetesGetGet(
        string type,
        string xSessionId,
        string xAuthenticationToken,
        string xAppId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| type |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string type = "type";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";

await measurements.GetApiV5DiabetesGetGet(type, xSessionId, xAuthenticationToken, xAppId);

```


### <a name="create_api_v5_diabetes_visualized_data_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.MeasurementsController.CreateApiV5DiabetesVisualizedDataPost") CreateApiV5DiabetesVisualizedDataPost

> # Specifications :-
> <b>URL : </b>/diabetes/visualized_data  
> <b>Method : </b>POST  
> # Parameters :-
> <b>Headers :</b>  
> 1- X-Authentication-Token  
> 2- X-Session-Id  
> 3- X-App-Id : should be sent only when using doctor app  
> <b>Params :</b>  
> 1- send_email  
> 2- type  
> <b>Note in Pregnancy App</b>  
> "type" param possible values are => glucose, blood_pressure, weight  
> # Response/JSON :-
> 1- <b>{"message":"mail sent"}, status: :ok</b>  
> 2- <b>{:graph => graph_url, count: count}, status: :ok</b>  
> 3- <b>{}, status: :unprocessable_entity</b>  
> providing Graph to the matched requested diabetes info  
> Two cases will apply:  
> 1- if the request is to send email contains the graph url to some one provided in the request params e.g "send_email: bla@bla.bla"  
> 2- if the request is just to get the corresponding graph to the matched [type, user]  


```csharp
Task CreateApiV5DiabetesVisualizedDataPost(
        string sendEmail,
        string type,
        string xSessionId,
        string xAuthenticationToken,
        string xAppId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| sendEmail |  ``` Required ```  | TODO: Add a parameter description |
| type |  ``` Required ```  | TODO: Add a parameter description |
| xSessionId |  ``` Required ```  | TODO: Add a parameter description |
| xAuthenticationToken |  ``` Required ```  | TODO: Add a parameter description |
| xAppId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string sendEmail = "send_email";
string type = "type";
string xSessionId = "X-Session-Id";
string xAuthenticationToken = "X-Authentication-Token";
string xAppId = "X-App-Id";

await measurements.CreateApiV5DiabetesVisualizedDataPost(sendEmail, type, xSessionId, xAuthenticationToken, xAppId);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="confirmation_controller"></a>![Class: ](https://apidocs.io/img/class.png "BalsameeAPIs.Standard.Controllers.ConfirmationController") ConfirmationController

### Get singleton instance

The singleton instance of the ``` ConfirmationController ``` class can be accessed from the API Client.

```csharp
ConfirmationController confirmation = client.Confirmation;
```

### <a name="create_api_v5_confirmations_send_confirmation_sms_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ConfirmationController.CreateApiV5ConfirmationsSendConfirmationSmsPost") CreateApiV5ConfirmationsSendConfirmationSmsPost

> TODO: Add Description


```csharp
Task CreateApiV5ConfirmationsSendConfirmationSmsPost(string xStatus, string individualId, string individualMobileNumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xStatus |  ``` Required ```  | TODO: Add a parameter description |
| individualId |  ``` Required ```  | TODO: Add a parameter description |
| individualMobileNumber |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xStatus = "X-Status";
string individualId = "individual[id]";
string individualMobileNumber = "individual[mobile_number]";

await confirmation.CreateApiV5ConfirmationsSendConfirmationSmsPost(xStatus, individualId, individualMobileNumber);

```


### <a name="get_api_v5_confirmations_confirm_email_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ConfirmationController.GetApiV5ConfirmationsConfirmEmailGet") GetApiV5ConfirmationsConfirmEmailGet

> TODO: Add Description


```csharp
Task GetApiV5ConfirmationsConfirmEmailGet(
        int individualId,
        string email,
        string confirmationCode,
        string xStatus)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| individualId |  ``` Required ```  | TODO: Add a parameter description |
| email |  ``` Required ```  | TODO: Add a parameter description |
| confirmationCode |  ``` Required ```  | TODO: Add a parameter description |
| xStatus |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int individualId = 98;
string email = "email";
string confirmationCode = "confirmation_code";
string xStatus = "X-Status";

await confirmation.GetApiV5ConfirmationsConfirmEmailGet(individualId, email, confirmationCode, xStatus);

```


### <a name="get_api_v5_confirmations_confirm_mobile_get"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ConfirmationController.GetApiV5ConfirmationsConfirmMobileGet") GetApiV5ConfirmationsConfirmMobileGet

> TODO: Add Description


```csharp
Task GetApiV5ConfirmationsConfirmMobileGet(
        int individualId,
        double mobileNumber,
        int confirmationCode,
        string xStatus)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| individualId |  ``` Required ```  | TODO: Add a parameter description |
| mobileNumber |  ``` Required ```  | TODO: Add a parameter description |
| confirmationCode |  ``` Required ```  | TODO: Add a parameter description |
| xStatus |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int individualId = 98;
double mobileNumber = 98.1411715914221;
int confirmationCode = 98;
string xStatus = "X-Status";

await confirmation.GetApiV5ConfirmationsConfirmMobileGet(individualId, mobileNumber, confirmationCode, xStatus);

```


### <a name="create_api_v5_confirmations_send_confirmation_mail_post"></a>![Method: ](https://apidocs.io/img/method.png "BalsameeAPIs.Standard.Controllers.ConfirmationController.CreateApiV5ConfirmationsSendConfirmationMailPost") CreateApiV5ConfirmationsSendConfirmationMailPost

> TODO: Add Description


```csharp
Task CreateApiV5ConfirmationsSendConfirmationMailPost(string xStatus, string individualId, string individualEmail)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xStatus |  ``` Required ```  | TODO: Add a parameter description |
| individualId |  ``` Required ```  | TODO: Add a parameter description |
| individualEmail |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xStatus = "X-Status";
string individualId = "individual[id]";
string individualEmail = "individual[email]";

await confirmation.CreateApiV5ConfirmationsSendConfirmationMailPost(xStatus, individualId, individualEmail);

```


[Back to List of Controllers](#list_of_controllers)



