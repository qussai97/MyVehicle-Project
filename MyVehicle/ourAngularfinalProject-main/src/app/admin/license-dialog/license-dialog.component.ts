import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { HomeService } from 'src/app/Service/home.service';

@Component({
  selector: 'app-license-dialog',
  templateUrl: './license-dialog.component.html',
  styleUrls: ['./license-dialog.component.css']
})
export class LicenseDialogComponent implements OnInit {
   

  formGroup =new FormGroup({
    minValue: new FormControl('', [Validators.required]),
    maxValue:new FormControl('',[Validators.required]),
    engineType:new FormControl('',[Validators.required]),
    numberPassengers: new FormControl('', [Validators.required]),
   cost: new FormControl('', [Validators.required]),
   
    
  }) 

  constructor(private home:HomeService) { }

  ngOnInit(): void {
  }
  minValuedata:any;
  maxValuedata:any;
  engineTypedata:any;
  numberPassengersdata:any;
  costdata:any;
  
 
  saveItem(){
    debugger
    this.minValuedata=this.formGroup.value.minValue;
    this.maxValuedata=this.formGroup.value.maxValue;
    this.engineTypedata=this.formGroup.value.engineType;
    this.numberPassengersdata=this.formGroup.value.numberPassengers;
    this.costdata=this.formGroup.value.cost;
    const data2={

      minValue:parseInt(this.minValuedata),
      maxValue:parseInt(this.maxValuedata),
      engineType:this.engineTypedata,
      numberPassengers:parseInt(this.numberPassengersdata),
      cost:parseInt(this.costdata),
      

    }
    console.log(data2)
    this.home.InsertLicensing(data2);
    // window.location.reload();

  }

}
