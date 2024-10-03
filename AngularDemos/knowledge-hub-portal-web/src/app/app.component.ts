import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { HomeComponent } from './home/home.component';
import { NavbarComponent } from './navbar/navbar.component';
import { ListCategoryComponent } from './list-category/list-category.component';
import { CreateCategoryComponent } from './create-category/create-category.component';
import { NotfoundComponent } from './notfound/notfound.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,HeaderComponent,FooterComponent,HomeComponent, NavbarComponent, ListCategoryComponent, CreateCategoryComponent,NotfoundComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'knowledge-hub-portal-web';
}
