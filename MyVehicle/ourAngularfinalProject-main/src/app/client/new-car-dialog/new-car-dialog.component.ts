import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { DomSanitizer } from '@angular/platform-browser';
import { HomeService } from 'src/app/Service/home.service';
import { NewCarLicensing } from 'src/app/shared/modules/vehicle';
@Component({
  selector: 'app-new-car-dialog',
  templateUrl: './new-car-dialog.component.html',
  styleUrls: ['./new-car-dialog.component.css']
})
export class NewCarDialogComponent implements OnInit {
  
  formGroup = new FormGroup({
    vehicleName: new FormControl('', [Validators.required]),
    vehicleModel: new FormControl('', [Validators.required]),
    vehicleColor: new FormControl('', [Validators.required]),
    vehicleCategory: new FormControl('', [Validators.required]),
    useType: new FormControl('', [Validators.required]),
    registerType: new FormControl('', [Validators.required]),
    licenseNumber: new FormControl('', [Validators.required]),
    licenseExpiry: new FormControl('', [Validators.required]),
    engineCapacity: new FormControl('', [Validators.required]),
    engineType: new FormControl('', [Validators.required]),
    madeYear: new FormControl('', [Validators.required]),
    licensingCenter: new FormControl('', [Validators.required]),
    chassisNumber: new FormControl('', [Validators.required]),
    engineNumber: new FormControl('', [Validators.required]),
    address: new FormControl('', [Validators.required]),
    vehicleImage: new FormControl('', [Validators.required]),
    //  userId: new FormControl('', [Validators.required]),
    licensingId: new FormControl('', [Validators.required]),
    insuranceId: new FormControl('', [Validators.required]),

  })
  constructor(public home:HomeService,private sanitizer: DomSanitizer,private dialog: MatDialog) { }
  myForm = new FormGroup({
    name: new FormControl('', [Validators.required, Validators.minLength(3)]),
    file: new FormControl('', [Validators.required]),
    fileSource: new FormControl('', [Validators.required])
  });
  ngOnInit(): void {
  }
  imageSrc: string='';
  // vehicleNamedata: any;
  // vehicleModeldata: any;
  // vehicleColordata: any;
  // vehicleCategorydata: any;
  // useTypedata: any;
  // registerTypedata: any;
  // licenseNumberdata: any;
  // licenseExpirydata: any;
  // engineCapacitydata: any;
  // engineTypedata: any;
  // madeYeardata: any;
  // licensingCenterdata: any;
  // chassisNumberdata: any;
  // engineNumberdata: any;
  // addressdata: any;
  // vehicleImagedata: string="image";
 
  // licensingIddata: any;
  // insuranceIddata: any;
   user:any=localStorage.getItem('user');
   user1=JSON.parse(this.user);
          
   userIddata=parseInt(this.user1.email)

   saveItem()
  {
      
        const car: NewCarLicensing = this.formGroup.value;
       
        car.userId=this.userIddata;
        car.licensingId=parseInt( car.licensingId);
        car.insuranceId= parseInt(car.insuranceId);
console.log(car);
        this.home.InsertNewCarLicensing(car);
        // window.location.reload();
        
  }
  vehicle: NewCarLicensing = new NewCarLicensing()
  localUrl: any;
  onFileChanged(event: any) {
    const file = event.target.value
    let name = <string>file;
    if (event.target.files && event.target.files[0]) {
      var reader = new FileReader();
      reader.onload = (event: any) => {
        this.localUrl = event.target.result;
        this.vehicle.vehicleImage = this.localUrl
        
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
        this.formGroup.controls.vehicleImage.setValue(this.imageSrc);
        this.myForm.patchValue({
          fileSource: reader.result
        });

       // console.log(this.imageSrc);

      };
    }
  }
  // saveItem() {
  //   debugger
  //   this.vehicleNamedata = this.formGroup.value.vehicleName;
  //   this.vehicleModeldata = this.formGroup.value.vehicleModel;
  //   this.vehicleColordata = this.formGroup.value.vehicleColor;
  //   this.vehicleCategorydata = this.formGroup.value.vehicleCategory;
  //   this.useTypedata = this.formGroup.value.useType;
  //   this.registerTypedata = this.formGroup.value.registerType;
  //   this.licenseNumberdata = this.formGroup.value.licenseNumber;
  //   this.licenseExpirydata = this.formGroup.value.licenseExpiry;
  //   this.engineCapacitydata = this.formGroup.value.engineCapacity;
  //   this.engineTypedata = this.formGroup.value.engineType;
  //   this.madeYeardata = this.formGroup.value.madeYear;
  //   this.licensingCenterdata = this.formGroup.value.licensingCenter;
  //   this.chassisNumberdata = this.formGroup.value.chassisNumber;
  //   this.engineNumberdata = this.formGroup.value.engineNumber;
  //   this.addressdata = this.formGroup.value.address;
  //   this.vehicleImagedata = this.vehicleImagedata;
  //   this.userIddata = this.userIddata;
  //   this.licensingIddata = this.formGroup.value.licensingId;
  //   this.insuranceIddata = this.formGroup.value.insuranceId;

  //   const data2 = {
  //     vehicleName: this.vehicleNamedata,
  //     vehicleModel: this.vehicleModeldata,
  //     vehicleColor: this.vehicleColordata,
  //     vehicleCategory: this.vehicleCategorydata,
  //     useType: this.useTypedata,
  //     registerType: this.registerTypedata,
  //     licenseNumber: this.licenseNumberdata,
  //     licenseExpiry: this.licenseExpirydata,
  //     engineCapacity: parseInt(this.engineCapacitydata),
  //     engineType: this.engineTypedata,
  //     madeYear: this.madeYeardata,
  //     licensingCenter: this.licensingCenterdata,
  //     chassisNumber: this.chassisNumberdata,
  //     engineNumber: this.engineNumberdata,
  //     address: this.addressdata,
  //     vehicleImage: this.vehicleImagedata,
  //     userId: this.userIddata,
  //     licensingId: parseInt(this.licensingIddata),
  //     insuranceId: parseInt(this.insuranceIddata)


  //   }
  //   console.log(data2)
  //   this.home.InsertNewCarLicensing(data2);
  //   // window.location.reload();

  // }
  

}
