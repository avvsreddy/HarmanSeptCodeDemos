
import { Component, inject, OnInit } from '@angular/core';
import { Location } from '@angular/common';
import { Category } from '../models/category';
import { FormsModule } from '@angular/forms';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'app-edit-category',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './edit-category.component.html',
  styleUrl: './edit-category.component.css'
})
export class EditCategoryComponent implements OnInit {

categoryService:CategoryService = inject(CategoryService);

  submitForm() {
this.categoryService.putCategory(this.category);//.subscribe( res => {});
}
  category: Category;

  constructor(private location: Location) {}

  ngOnInit(): void {
    const queryParams = this.location.path().split('?')[1];
    if (queryParams) {
      this.category = JSON.parse(decodeURIComponent(queryParams.split('=')[1]));
    }
    console.log(this.category);
  }
}
