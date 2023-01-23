import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { HomeService } from 'src/app/Service/home.service';

@Component({
  selector: 'app-insurance-dialog',
  templateUrl: './insurance-dialog.component.html',
  styleUrls: ['./insurance-dialog.component.css']
})
export class InsuranceDialogComponent implements OnInit {

  formGroup =new FormGroup({
    InsuranceType: new FormControl('', [Validators.required]),
    InsuranceValues:new FormControl('',[Validators.required]),
  
    
    
  }) 
  
  constructor(private home:HomeService) { }

  ngOnInit(): void {
  }
  type:any;
  value:any;
  
  saveItem(){
    debugger
    this.type=this.formGroup.value.InsuranceType;
    this.value=this.formGroup.value.InsuranceValues;
    
    const data2={

      InsuranceType:this.type.toString(),
      InsuranceValues:parseFloat(this.value),
      


    }
    console.log(data2)
    this.home.CreateInsurance(data2);
    // window.location.reload();

  }
}
