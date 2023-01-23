import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { AdminComponent } from './admin/admin.component';
import { SharedModule } from '../shared/shared.module';

import { DialogComponent } from './dialog/dialog.component';
import { CreatEmployeeComponent } from './creat-employee/creat-employee.component';
import { ChartComponent } from './chart/chart.component';
import { ReportComponent } from './report/report.component';
import { FinancialReportComponent } from './financial-report/financial-report.component';
import { SearchByVehicleCategoryComponent } from './search-by-vehicle-category/search-by-vehicle-category.component';
import { GetAttendanceComponent } from './get-attendance/get-attendance.component';
import { SearchingForVehiclesLicenseExpiryComponent } from './searching-for-vehicles-license-expiry/searching-for-vehicles-license-expiry.component';
import { TotalMonthSalariesComponent } from './total-month-salaries/total-month-salaries.component';
import { GetTotalPaymentComponent } from './get-total-payment/get-total-payment.component';
import { AddTaskJobComponent } from './add-task-job/add-task-job.component';
import { TaskJobDialogComponent } from './task-job-dialog/task-job-dialog.component';
import { ProfileComponent } from './profile/profile.component';
import { AddLicenseComponent } from './add-license/add-license.component';
import { LicenseDialogComponent } from './license-dialog/license-dialog.component';
import { AddInsuranceComponent } from './add-insurance/add-insurance.component';

import { VehicleSystemReportBetweenComponent } from './vehicle-system-report-between/vehicle-system-report-between.component';

import { UpdateProfileDialogComponent } from './update-profile-dialog/update-profile-dialog.component';
import { InsuranceDialogComponent } from './insurance-dialog/insurance-dialog.component';



@NgModule({
  declarations: [
    AdminComponent,
    CreatEmployeeComponent,
    ChartComponent,
    ReportComponent,
    FinancialReportComponent,
    DialogComponent,
    SearchByVehicleCategoryComponent,
    GetAttendanceComponent,
    SearchingForVehiclesLicenseExpiryComponent,
    TotalMonthSalariesComponent,
    GetTotalPaymentComponent,
    AddTaskJobComponent,
    TaskJobDialogComponent,
    ProfileComponent,
    AddLicenseComponent,
    LicenseDialogComponent,
    AddInsuranceComponent,
    InsuranceDialogComponent,

    VehicleSystemReportBetweenComponent,

    UpdateProfileDialogComponent

  ],
  imports: [
    CommonModule,
    AdminRoutingModule,
    SharedModule
  ]
})
export class AdminModule { }
