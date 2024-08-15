import { Component } from '@angular/core';
import { CategoryService } from '../Services/category.service';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrl: './add-category.component.css'
})
export class AddCategoryComponent {

  constructor(private serv: CategoryService) { }

  name: string = '';

  AddCategory() {
    this.serv.AddCategory(this.name).subscribe(res => { });
  }

}
