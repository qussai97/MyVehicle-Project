import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { HomeService } from 'src/app/Service/home.service';
@Component({
  selector: 'app-task-job-dialog',
  templateUrl: './task-job-dialog.component.html',
  styleUrls: ['./task-job-dialog.component.css']
})
export class TaskJobDialogComponent implements OnInit {
    
  formGroup =new FormGroup({
    taskDescription: new FormControl('', [Validators.required]),
    taskDate:new FormControl('',[Validators.required]),
    userId: new FormControl('', [Validators.required]),
   
    
  }) 

  constructor(public home:HomeService) { }

  ngOnInit(): void {
  }
  taskDescriptiondata:any;
  taskDatedata:any;
  userIddata:any;
 
  saveItem(){
    debugger
    this.taskDescriptiondata=this.formGroup.value.taskDescription;
    this.taskDatedata=this.formGroup.value.taskDate;
    this.userIddata=this.formGroup.value.userId;
 
    const data2={

      taskDescription:this.taskDescriptiondata,
      taskDate:this.taskDatedata,
      userId:parseInt(this.userIddata),
      

    }
    console.log(data2)
    this.home.InsertTaskJob(data2);
    // window.location.reload();

  }
}
