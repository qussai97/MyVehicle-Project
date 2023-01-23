import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { HomeService } from 'src/app/Service/home.service';

@Component({
  selector: 'app-attendance-dialog',
  templateUrl: './attendance-dialog.component.html',
  styleUrls: ['./attendance-dialog.component.css']
})
export class AttendanceDialogComponent implements OnInit {
  formGroup =new FormGroup({
    AtStartDate: new FormControl('', [Validators.required]),
    AtEndDate:new FormControl('',[Validators.required]),
    
    
    // UserId:new FormControl('',[Validators.required]),
    
    
  })
  constructor(private home:HomeService) { }

  ngOnInit(): void {
  }
  StartDate:any;
  EndDate:any;
  
  Status:number=1;
   user:any=localStorage.getItem('user');
   user1=JSON.parse(this.user);
          
   userIddata=parseInt(this.user1.email)
  
  saveItem(){
    debugger
    this.StartDate=this.formGroup.value.AtStartDate;
    this.EndDate=this.formGroup.value.AtEndDate;
    
    this.Status=this.Status;
    this.userIddata=this.userIddata;
    
    const data2={
      AtStartDate:this.StartDate.toString(),
      AtEndDate:this.EndDate.toString(),
      
      
      UserId:this.userIddata,
      AtStatus:Boolean(this.Status),
      
    }
    console.log(data2)
    this.home.Createattendance(data2);
    // window.location.reload();

  }
}
