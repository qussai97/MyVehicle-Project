import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AccountantRoutingModule } from './accountant-routing.module';
import { AccountantComponent } from './accountant/accountant.component';
import { SharedModule } from '../shared/shared.module';
import { ReportsComponent } from './reports/reports.component';
import { UserInfoComponent } from './user-info/user-info.component';
import { EmployeeInfoComponent } from './employee-info/employee-info.component';
import { AttendanceComponent } from './attendance/attendance.component';
import { AttendanceDialogComponent } from './attendance-dialog/attendance-dialog.component';
import { ProfileComponent } from './profile/profile.component';
import { GetTaskJobComponent } from './get-task-job/get-task-job.component';
import { AddMessageComponent } from './add-message/add-message.component';
import { MessageDialogComponent } from './message-dialog/message-dialog.component';
import { VehicleSystemReportBetweenComponent } from './vehicle-system-report-between/vehicle-system-report-between.component';
import { UserContactInfoComponent } from './user-contact-info/user-contact-info.component';


@NgModule({
  declarations: [
    AccountantComponent,
    ReportsComponent,
    UserInfoComponent,
    EmployeeInfoComponent,
    AttendanceComponent,
    AttendanceDialogComponent,
    ProfileComponent,
    GetTaskJobComponent,
    AddMessageComponent,
    MessageDialogComponent,
    VehicleSystemReportBetweenComponent,
    UserContactInfoComponent,
    
  ],
  imports: [
    CommonModule,
    AccountantRoutingModule,
    SharedModule
  ]
})
export class AccountantModule { }
