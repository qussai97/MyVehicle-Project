import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { DomSanitizer } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/Service/auth.service';
import { UserRegistration } from 'src/app/shared/modules/customer';
import { Users } from 'src/app/shared/modules/user';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  Role:number=2;
  Setting:number=1;
  gender:boolean=true;
  genderName:string="Male";
  
  formGroup =new FormGroup({
    fullName: new FormControl('', [Validators.required]),
    userImage:new FormControl('',[Validators.required]),
    gender: new FormControl('', [Validators.required]),
    email:new FormControl('', [Validators.required,Validators.email]),
    age: new FormControl('', [Validators.required]),
    address: new FormControl('', [Validators.required]),
    phoneNumber : new FormControl('',[Validators.required]),
    username :new FormControl('', [Validators.required]),
    password : new FormControl('', [Validators.required,Validators.minLength(10)]),
    confirmPassword: new FormControl('', [Validators.required,Validators.minLength(10)])

  
})
  constructor(private router:Router,public authService :AuthService,private sanitizer: DomSanitizer) { }

  
  myForm = new FormGroup({
    name: new FormControl('', [Validators.required, Validators.minLength(3)]),
    file: new FormControl('', [Validators.required]),
    fileSource: new FormControl('', [Validators.required])
  });
  ngOnInit(): void {
  }
  imageSrc: string='';

  saveregister()
  {
      
        const user: Users = this.formGroup.value;
        user.settingId=this.Setting;
        user.roleId=this.Role;
        user.gender=this.gender;
        
console.log(user);
        this.authService.register(user);
        // window.location.reload();
        this.router.navigate(['/security/login'])
       
        
  }
  customer: Users = new Users()
  localUrl: any;
  onFileChanged(event: any) {
    const file = event.target.value
    let name = <string>file;
    if (event.target.files && event.target.files[0]) {
      var reader = new FileReader();
      reader.onload = (event: any) => {
        this.localUrl = event.target.result;
        this.customer.userImage = this.localUrl
        
      }
      reader.readAsDataURL(event.target.files[0]);
    }
  }

  transform() {

    return this.sanitizer.bypassSecurityTrustResourceUrl(this.localUrl);
  }

  get f() {
    return this.myForm.controls;
  }


  onFileChange(event: any) {
    const reader = new FileReader();

    if (event.target.files && event.target.files.length) {
      const [file] = event.target.files;
      reader.readAsDataURL(file);

      reader.onload = () => {
        this.imageSrc = reader.result as string;
        this.formGroup.controls.userImage.setValue(this.imageSrc);
        this.myForm.patchValue({
          fileSource: reader.result
        });

       // console.log(this.imageSrc);

      };
    }
  }
  // saveregister(){
  //   const User={
  //   fullName:this.formGroup.value.fullNameControl.toString(),
  //   userImage:this.image,
  //   gender:this.gender,
  //   age:parseInt(this.formGroup.value.AgeControl),
  //   email:this.formGroup.value.emailControl.toString(),
  //   phoneNumber:parseInt(this.formGroup.value.phoneNumberControl),
  //   address:this.formGroup.value.addressControl.toString(),
  //   username:this.formGroup.value.usernameControl.toString(),
  //   password:this.formGroup.value.passwordControl.toString(),
  //   roleId:this.Role,
  //   settingId:this.Setting
  //   }
  //   console.log(User)
  //   this.authService.register(User);
  // }
 



  onchang(){
    if (this.formGroup.controls.password.value== this.formGroup.controls.confirmPassword.value) {
    this.formGroup.controls.confirmPassword.setErrors(null);
    } else{
    this.formGroup.controls.confirmPassword.setErrors({ mismatch:true});
    } }



  submit(){
    
  }

}
