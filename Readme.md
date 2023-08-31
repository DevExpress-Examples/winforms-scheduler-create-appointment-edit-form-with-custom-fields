<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128636295/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2782)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WinForms Scheduler - Create an appointment edit form with custom fields

[Custom fields](https://docs.devexpress.com/WindowsForms/17137/controls-and-libraries/scheduler/data-binding/mappings/custom-fields) allow you to display arbitrary information with appointments. This example shows how to use custom fields to display, edit, and save arbitrary information. The application uses an MS Access database as a data source. 

In this example:

* Custom field mappings are set up at design time using the **Mapping Wizard**. 
* The [InitNewAppointment](https://docs.devexpress.com/WindowsForms/DevExpress.XtraScheduler.SchedulerControl.InitNewAppointment) event is handled to initialize custom fields.
* The [AppointmentInserting](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraScheduler.SchedulerStorageBase.AppointmentInserting) and [AppointmentChanging](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraScheduler.SchedulerStorageBase.AppointmentChanging) events are handled to log changes and to prevent certain appointments from being created or modified.
* Implemented a custom appointment form. The form derives form the `DevExpress.XtraScheduler.UI.AppointmentForm` class and includes additional UI controls that correspond to custom fields.
* Implemented a custom form controller that loads and saves custom fields. The form controller derives from the `DevExpress.XtraScheduler.UI.AppointmentFormController` class and overrides certain methods.


## Documentation

* [Custom Fields](https://docs.devexpress.com/WindowsForms/17137/controls-and-libraries/scheduler/data-binding/mappings/custom-fields)
* [How to: Create Appointments with Custom Fields](https://docs.devexpress.com/WindowsForms/5228/controls-and-libraries/scheduler/examples/data-binding/how-to-create-appointments-with-custom-fields)


## See Also

* [Custom form, custom fields and custom actions on reminder alert](https://www.devexpress.com/Support/Center/p/E382)
* [How to Customize an Appointment Recurrence Form](https://docs.devexpress.com/WindowsForms/2880/controls-and-libraries/scheduler/examples/forms/how-to-create-a-custom-appointment-recurrence-form-method-1)
