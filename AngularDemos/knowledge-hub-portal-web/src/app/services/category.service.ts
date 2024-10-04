import { HttpClient } from "@angular/common/http";
import { inject, Injectable } from "@angular/core";
import { Category } from "../models/category";



@Injectable({
    providedIn:"root"
})
export class CategoryService{

private http:HttpClient=inject(HttpClient);

// constructor(http:HttpClient){
//     this.http = http;
// }


getCategories(){
    // get categories from api
    // url: https://localhost:44300/api/Categories
    let apiUrl:string='https://localhost:44300/api/Categories';
    //http: HttpClient=new HttpClient();
     return this.http.get<Category[]>(apiUrl)
}

postCategory(category:Category){
    // post category to api
    // url: https://localhost:44300/api/Categories
    let apiUrl:string='https://localhost:44300/api/Categories';
    return this.http.post(apiUrl,category);
}

}