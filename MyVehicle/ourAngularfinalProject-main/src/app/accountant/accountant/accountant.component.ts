import { Component, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { HomeService } from 'src/app/Service/home.service';
import { AttendanceDialogComponent } from '../attendance-dialog/attendance-dialog.component';
import { MessageDialogComponent } from '../message-dialog/message-dialog.component';

@Component({
  selector: 'app-accountant',
  templateUrl: './accountant.component.html',
  styleUrls: ['./accountant.component.css']
})
export class AccountantComponent implements OnInit {
  @Input () paymentCount:number|undefined;
  Name:string="undefined";
  
  currentYear:Date|any = undefined;
  constructor(private router:Router,public homeService:HomeService ,
    public tostr:ToastrService,private dialog:MatDialog)  {
    this.currentYear = new Date().getFullYear();
    this.Name="MyVehicle Team"
    
    
   }
  ngOnInit(): void {
    this.GetCountPayment();
    this.GetAllSalary();
    this.GetAllPayments();
  }
  logout()
  {
    localStorage.clear();
    this.router.navigate(['security/login']);
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
  GetCountPayment(){
    this.homeService.GetCountPayment().subscribe((res:any)=>{
      this.homeService.paymentCount=res;

    },err=>{

    });
    

  }
  GetAllSalary(){
    this.homeService.GetAllSalary().subscribe((res:any)=>{
      this.homeService.data1=res;
     console.log(this.homeService.data)
     
    },err=>{
      console.log("err")
    });
    

  }
  GetAllPayments(){ this.homeService.GetAllPayments().subscribe((res:any)=>{
    this.homeService.payment=res;
   console.log(this.homeService.payment)
   
  },err=>{
    console.log("err")
  });
  

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
        
  this.homeService.GetSalaryByUserId(id);
       this.homeService.GetUserByIdAcc(id)
      }
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
       
      this.homeService.GetTaskJobById(id)
    }
  }
}
