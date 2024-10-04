import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { CreateCategoryComponent } from './create-category/create-category.component';
import { ListCategoryComponent } from './list-category/list-category.component';
import { NotfoundComponent } from './notfound/notfound.component';
import { EditCategoryComponent } from './edit-category/edit-category.component';

export const routes: Routes = 
[
    {
        path:'', component: HomeComponent
    },
    {
        path:'home', component:HomeComponent, title:'Knowledge Hub Portal - Home'
    },
    {
        path:'create-category',component:CreateCategoryComponent, title:'Knowledge Hub Portal - Create Category'
    },
    {
        path:'list-category',component:ListCategoryComponent, title:'Knowledge Hub Portal - List Category'
    },
    {
        path:'edit-category',component:EditCategoryComponent, title:'Knowledge Hub Portal - Edit Category'
    },
    
    {
        path:'**',component:NotfoundComponent, title:'Knowledge Hub Portal - Not Found'
    }
];
