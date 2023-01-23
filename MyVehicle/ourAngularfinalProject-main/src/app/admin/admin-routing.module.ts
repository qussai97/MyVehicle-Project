import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddInsuranceComponent } from './add-insurance/add-insurance.component';
import { AddLicenseComponent } from './add-license/add-license.component';
import { AddTaskJobComponent } from './add-task-job/add-task-job.component';
import { AdminComponent } from './admin/admin.component';
import { ChartComponent } from './chart/chart.component';
import { CreatEmployeeComponent } from './creat-employee/creat-employee.component';
import { FinancialReportComponent } from './financial-report/financial-report.component';
import { GetAttendanceComponent } from './get-attendance/get-attendance.component';
import { GetTotalPaymentComponent } from './get-total-payment/get-total-payment.component';
import { ProfileComponent } from './profile/profile.component';
import { ReportComponent } from './report/report.component';
import { SearchByVehicleCategoryComponent } from './search-by-vehicle-category/search-by-vehicle-category.component';
import { SearchingForVehiclesLicenseExpiryComponent } from './searching-for-vehicles-license-expiry/searching-for-vehicles-license-expiry.component';
import { TotalMonthSalariesComponent } from './total-month-salaries/total-month-salaries.component';
import { VehicleSystemReportBetweenComponent } from './vehicle-system-report-between/vehicle-system-report-between.component';

export const routes: Routes = [
  {
    path:'admin',
  component:AdminComponent
  },
  {
    path:'creat-employee',
    component:CreatEmployeeComponent
  },
  {
    path:'chart',
    component:ChartComponent
  },
  {
    path:'report',
    component:ReportComponent
  },
  {
    path:'financial-report',
    component:FinancialReportComponent
  },
  {
    path:'search-by-vehicle-category',
    component:SearchByVehicleCategoryComponent
  },
  {
    path:'get-attendance',
    component:GetAttendanceComponent
  },
  {
    path:'searching-for-vehicles-license-expiry',
    component:SearchingForVehiclesLicenseExpiryComponent
  },
  {
    path:'total-month-salaries',
    component:TotalMonthSalariesComponent
  },
  {
    path:'total-payment',
    component:GetTotalPaymentComponent
  },
  {
    path:'add-task-job',
    component:AddTaskJobComponent
  },
  {
    path:'profile',
    component:ProfileComponent
  },

  {
    path:'add-insurance',
    component:AddInsuranceComponent
  },
  {
    path:'add-license',
    component:AddLicenseComponent
  },
  
  { path: '', redirectTo: '/add-license', pathMatch: 'full'},
  
  { path: '', redirectTo: '/add-insurance', pathMatch: 'full'},
  
  { path: '', redirectTo: '/profile', pathMatch: 'full'},
  { path: '', redirectTo: '/add-task-job', pathMatch: 'full'},
  
  { path: '', redirectTo: '/total-payment', pathMatch: 'full'},
  
  { path: '', redirectTo: '/total-month-salaries', pathMatch: 'full'},
  
  { path: '', redirectTo: '/searching-for-vehicles-license-expiry', pathMatch: 'full'},
  
  { path: '', redirectTo: '/get-attendance', pathMatch: 'full'},
  { path: '', redirectTo: '/admin', pathMatch: 'full'},
  { path: '', redirectTo: '/creat-employee', pathMatch: 'full'},
  { path: '', redirectTo: '/chart', pathMatch: 'full'},
  { path: '', redirectTo: '/report', pathMatch: 'full'},
  { path: '', redirectTo: '/financial-report', pathMatch: 'full'},
  { path: '', redirectTo: '/search-by-vehicle-category', pathMatch: 'full'},
  {
    path:'vehicle-system-report-between',
    component:VehicleSystemReportBetweenComponent
  },
  {
    path :'licing',
    component:AddLicenseComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
