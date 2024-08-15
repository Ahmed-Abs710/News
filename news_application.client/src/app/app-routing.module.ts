import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { NewsComponent } from './news/news.component';
import { AddUserComponent } from './add-user/add-user.component';
import { AddCategoryComponent } from './add-category/add-category.component';
import { AddArticleComponent } from './add-article/add-article.component';
import { RegisterComponent } from './register/register.component';
import { ShowArticleComponent } from './show-article/show-article.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: NewsComponent
  }, {
    path: 'Dashboard',
    component: DashboardComponent, children: [
      { path: 'Adduser', component: AddUserComponent },
      { path: 'Addcategory', component: AddCategoryComponent },
      { path: 'Addarticle', component: AddArticleComponent }
    ]
  }, {
    path: 'Register',
    component : RegisterComponent
  }, {
    path: 'Login',
    component: LoginComponent
  },{
    path: 'Article',
    component: ShowArticleComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
