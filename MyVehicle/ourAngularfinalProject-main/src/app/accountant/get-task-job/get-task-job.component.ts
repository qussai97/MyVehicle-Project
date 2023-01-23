import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { HomeService } from 'src/app/Service/home.service';
import { AttendanceDialogComponent } from '../attendance-dialog/attendance-dialog.component';
import { MessageDialogComponent } from '../message-dialog/message-dialog.component';

@Component({
  selector: 'app-get-task-job',
  templateUrl: './get-task-job.component.html',
  styleUrls: ['./get-task-job.component.css']
})
export class GetTaskJobComponent implements OnInit {

  Name:string="undefined";
  
  currentYear:Date|any = undefined;
  constructor(private router:Router,private dialog:MatDialog ,public home:HomeService)  {
    this.currentYear = new Date().getFullYear();
    this.Name="MyVehicle Team"
    
    
   }
  ngOnInit(): void {
  }
  logout()
  {
    localStorage.clear();
    this.router.navigate(['security/login']);
  }
  showProfile()
    {
      //I will get the user from the local storge 
      let user:any=localStorage.getItem('user');
      user=JSON.parse(user);
      
       const id=parseInt(user.email)
       console.log(id)
      if(id)
      {
        this.home.GetSalaryByUserId(id);
        this.home.GetUserByIdAcc(id)
      }
    }
  GoToAbout()
  {
    this.router.navigate(['about'])
  }

  GoToContact()
  {
    this.router.navigate(['contactus'])
  }
  
  GoToHome()
  {
    
    this.router.navigate([''])
  }

  InsertMessage()
  {
this.dialog.open(MessageDialogComponent)
  }
  createAttendance()
  {
    this.dialog.open(AttendanceDialogComponent)
  }
  GetTaskJob()
  {
    //I will get the user from the local storge 
    let user:any=localStorage.getItem('user');
    user=JSON.parse(user);
    
     const id=parseInt(user.email)
     console.log(id)
    if(id)
    {
       
      this.home.GetTaskJobById(id)
    }
  }
}
