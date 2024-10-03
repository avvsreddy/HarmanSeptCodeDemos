import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { CreateCategoryComponent } from './create-category/create-category.component';
import { ListCategoryComponent } from './list-category/list-category.component';
import { NotfoundComponent } from './notfound/notfound.component';

export const routes: Routes = 
[
    {
        path:'', component: HomeComponent
    },
    {
        path:'home', component:HomeComponent
    },
    {
        path:'create-category',component:CreateCategoryComponent
    },
    {
        path:'list-category',component:ListCategoryComponent
    },
    {
        path:'**',component:NotfoundComponent
    }
];
