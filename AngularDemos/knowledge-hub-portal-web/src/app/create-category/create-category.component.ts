import { Component, inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Category } from '../models/category';
import { HttpClient } from '@angular/common/http';
import { CategoryService } from '../services/category.service';
import { noNumberValidator } from '../validators/custom.validators';

@Component({
  selector: 'app-create-category',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './create-category.component.html',
  styleUrl: './create-category.component.css'
})
export class CreateCategoryComponent implements OnInit {

categoryForm:FormGroup;
ngOnInit(): void {
  this.categoryForm = new FormGroup({
    
      title:new FormControl('',[Validators.required,Validators.minLength(5), noNumberValidator]),
      description:new FormControl('',[Validators.required,Validators.maxLength(100),Validators.minLength(10)])
    })
}


categoryService:CategoryService = inject(CategoryService);

//category:Category={categoryID:0,title:'',description:''}


onFormSubmit(){
  console.log(this.categoryForm);
   this.categoryService.postCategory(this.categoryForm.value).subscribe(data => {
   alert("Category created successfully");
   
 });
    
  }
}


