import { Component, inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Category } from '../models/category';
import { HttpClient } from '@angular/common/http';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'app-create-category',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './create-category.component.html',
  styleUrl: './create-category.component.css'
})
export class CreateCategoryComponent implements OnInit {

formGroup:FormGroup;
ngOnInit(): void {
  this.formGroup = new FormGroup({
    
      title:new FormControl(''),
      description:new FormControl('')
    })
}

categoryService:CategoryService = inject(CategoryService);

category:Category={categoryID:0,title:'',description:''}


onFormSubmit(){
  //console.log(form);
   this.categoryService.postCategory(this.category).subscribe(data => {
   alert("Category created successfully");
   this.category.title='';
   this.category.description='';
 });
    
  }
}


