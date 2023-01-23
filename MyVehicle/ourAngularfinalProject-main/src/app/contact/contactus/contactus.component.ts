import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { HomeService } from 'src/app/Service/home.service';

@Component({
  selector: 'app-contactus',
  templateUrl: './contactus.component.html',
  styleUrls: ['./contactus.component.css']
})
export class ContactusComponent implements OnInit {
  @Input () name:any|undefined;
  @Input () subText:string|undefined;
  @Input () imag:string|undefined;
  TestimonialTel:number=7788;
  ProblemImage:string="1";
  settingId:number=1;
    formGroup = new FormGroup({
    fullNameControl: new FormControl('', [Validators.required]),
    emailControl: new FormControl('', [Validators.required,Validators.email]),
    phoneNumberControl: new FormControl('',Validators.required,),
    // Img: new FormControl('',Validators.required,),
    commentControl: new FormControl('', [Validators.required])
    });


webemail:string="undefined";
webPhone1:string="undefined";
webPhone2:string="undefined"
  webAddress:string="undefined";
  
  
  // carddata :any =[{
  //   name:"Hamza Al-Omary",
  //     subText:"Developer" ,
  //    imag:""
  // },
  // {
  //   name:"Qussi Al-Dogham " ,
  //    subText:"Developer" ,
  //    imag:""
  // },
  // {
  //   name:"Thraya Bani-Yaseen",
  //   subText:"Developer",
  //   imag:""
  // },
  // {
  //   name:"Taimaa Al-Hamarneh",
  //   subText:"Developer",
  //   imag:""
  // }]

  
  
  
  constructor(public homeService:HomeService) {

    this.webemail="MyVehicle@Company.com"
    this.webPhone1="+962-798562481"
    this.webPhone2="+962-797525063"
    this.webAddress="PQCR+WHF,Amman"
   }

  ngOnInit(): void {
  }

  sendTestimonial(){
   const message={
    TestimonialName:this.formGroup.value.fullNameControl.toString(),
    TestimonialEmail:this.formGroup.value.emailControl.toString(),
    TestimonialTel:parseInt(this.formGroup.value.phoneNumberControl),
    Comment:this.formGroup.value.commentControl.toString(),
    ProblemImage:this.ProblemImage,
    settingId:this.settingId

   }
   this.homeService.Testimonial(message);

  }


  submitForm(){
    
    //console.log(this.registerForm.controls);
  }

}
