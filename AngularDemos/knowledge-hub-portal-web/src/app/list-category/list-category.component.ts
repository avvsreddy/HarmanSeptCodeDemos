import { NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-list-category',
  standalone: true,
  imports: [NgFor],
  templateUrl: './list-category.component.html',
  styleUrl: './list-category.component.css'
})
export class ListCategoryComponent {

message:string = 'List of Categories';

categories:any[]=[
{
  id:111,
  name:'Sports',
  description:'Sports related articles'
},
{
  id:222,
  name:'.Net',
  description:'.Net related articles'
},
{
  id:333,
  name:'Angular',
  description:'Angular related articles'
},
{
  id:444,
  name:'Java',
  description:'Java related articles'
},
{
  id:555,
  name:'Python',
  description:'Python related articles'
},
{
  id:666,
  name:'JavaScript',
  description:'JavaScript related articles'
},
{
  id:777,
  name:'C++',
  description:'C++ related articles'
},
{
  id:888,
  name:'Ruby',
  description:'Ruby related articles'
},
{
  id:999,
  name:'Swift',
  description:'Swift related articles'
},
{
  id:1010,
  name:'Go',
  description:'Go related articles'
},
{
  id:1011,
  name:'Rust',
  description:'Rust related articles'
},
{
  id:1012,
  name:'TypeScript',
  description:'TypeScript related articles'
},
{
  id:1013,
  name:'Kotlin',
  description:'Kotlin related articles'
},
{
  id:1014,
  name:'PHP',
  description:'PHP related articles'
},
{
  id:1015,
  name:'SQL',
  description:'SQL related articles'
}
];

}
