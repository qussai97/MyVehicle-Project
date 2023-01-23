import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder,Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { DomSanitizer } from '@angular/platform-browser';
import { HomeService } from 'src/app/Service/home.service';
import { Users } from 'src/app/shared/modules/user';

// import {MatDialog, MatDialogRef} from '@angular/material/dialog';
@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrls: ['./dialog.component.css']
})
export class DialogComponent implements OnInit {
 
  formGroup =new FormGroup({
    username: new FormControl('', [Validators.required]),
    password:new FormControl('',[Validators.required]),
    
    fullName: new FormControl('', [Validators.required]),
    userImage: new FormControl('', [Validators.required]),  
    gender: new FormControl('', [Validators.required]),   
    age: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.required,Validators.email]),
    address: new FormControl('', [Validators.required]),
    phoneNumber: new FormControl('',[Validators.required]),
    
    
  }) 
  myForm = new FormGroup({
    name: new FormControl('', [Validators.required, Validators.minLength(3)]),
    file: new FormControl('', [Validators.required]),
    fileSource: new FormControl('', [Validators.required])
  });
  gender:boolean=true;
  genderName:string="Male";

  
  constructor(public home:HomeService,private sanitizer: DomSanitizer,private dialog: MatDialog) {
   
  }
  ngOnInit(): void {
  }
  
  roleIddata:number=3;
  
  
  imageSrc: string='';
  
  settingIddata:number=1;
  
  
  
  saveItem()
  {
      
        const emp: Users = this.formGroup.value;
        emp.settingId=this.settingIddata;
        emp.roleId=this.roleIddata;
        emp.gender=this.gender;
       
console.log(emp);
        this.home.CreateEmployee(emp);
        // window.location.reload();
        
  }
  employee: Users = new Users()
  localUrl: any;
  onFileChanged(event: any) {
    const file = event.target.value
   
    if (event.target.files && event.target.files[0]) {
      var reader = new FileReader();
      reader.onload = (event: any) => {
        this.localUrl = event.target.result;
        this.employee.userImage = this.localUrl
        
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
}
