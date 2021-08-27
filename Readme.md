<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128636295/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2782)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to use custom appointment fields in a custom editing form


<p>Custom fields for appointments provide a way to associate arbitrary information with an appointment. This example represents a simple application that enables you to display, edit and save data contained in appointment custom fields. The application uses MS Access database as the data source.<br> Custom field mappings are established at design time using <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument4227"><u>Mapping Wizards</u></a>.<br> The <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraSchedulerSchedulerControl_InitNewAppointmenttopic"><u>InitNewAppointment</u></a> event is handled to specify initial values for custom fields. The <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerSchedulerStorageBase_AppointmentInsertingtopic"><u>AppointmentInserting</u></a> and <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerSchedulerStorageBase_AppointmentChangingtopic"><u>AppointmentChanging</u></a> events are handled to log changes or to prevent certain appointments from being created or changed.<br> To work with custom fields, a new appointment form is implemented. It descends form the<strong> DevExpress.XtraScheduler.UI.AppointmentForm</strong>, includes additional controls required to represent custom fields. To load and save custom fields a custom form controller is implemented. It inherits from the <strong>DevExpress.XtraScheduler.UI.AppointmentFormController</strong> and overrides several methods to provide the required functionality.</p>
<p><strong>See also:</strong><strong><br></strong><a href="https://www.devexpress.com/Support/Center/p/E382">Custom form, custom fields and custom actions on reminder alert</a></p>

<br/>


