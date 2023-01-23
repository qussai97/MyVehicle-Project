import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { HomeService } from 'src/app/Service/home.service';

@Component({
  selector: 'app-update-profile-dialog',
  templateUrl: './update-profile-dialog.component.html',
  styleUrls: ['./update-profile-dialog.component.css']
})
export class UpdateProfileDialogComponent implements OnInit {

  formGroup =new FormGroup({
    
    
    fullName: new FormControl(''),
   
    gender: new FormControl(''),   
    age: new FormControl(''),
    email: new FormControl(''),
    address: new FormControl(''),
    phoneNumber: new FormControl(''),
    
    
  }) 
  
  constructor(public home:HomeService) {  }

  ngOnInit(): void {
    
    
     
  }
  user:any=localStorage.getItem('user');
  user1=JSON.parse(this.user);
  id:number=parseInt(this.user1.email);
  roleIddata:number=1;
  namedata:any;
  image:string="image";
  genderdata:any;
  agedata:any;
  emaildata:any;
  addressdata:any;
  phonedata:any;
  settingIddata:number=1;
  loginIddata:number=30
  saveItem(){
    debugger
    
    this.id=this.id,
    this.loginIddata=this.loginIddata,
    this.namedata=this.formGroup.value.fullName;
    this.image=this.image;
    this.genderdata=this.formGroup.value.gender;
    this.agedata=this.formGroup.value.age;
    this.emaildata=this.formGroup.value.email;
    this.addressdata=this.formGroup.value.address;
    this.phonedata=this.formGroup.value.phoneNumber;
    this.settingIddata=this.settingIddata;

    const data2={

      
      userId:this.id,
      fullName:this.namedata.toString(),
      userImage:this.image,
      gender:Boolean(this.genderdata),
      age: parseInt(this.agedata),
      email: this.emaildata.toString(),
      address: this.addressdata.toString(),
      phoneNumber:parseInt( this.phonedata),
      settingId:this.settingIddata,
      loginId:this.loginIddata,
      

    }
    console.log(data2)
    this.home.UpdateProfile(data2);
    //  window.location.reload();

  }
}
