import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DashboardComponent } from './dashboard/dashboard.component';
import { NewsComponent } from './news/news.component';
import { AddUserComponent } from './add-user/add-user.component';
import { AddCategoryComponent } from './add-category/add-category.component';
import { AddArticleComponent } from './add-article/add-article.component';
import { EditorModule } from '@tinymce/tinymce-angular';
import { QuillModule } from 'ngx-quill';
import { NgxEditorModule } from 'ngx-editor';
import { NgxSimpleTextEditorModule } from 'ngx-simple-text-editor';
import { RegisterComponent } from './register/register.component';
import { ShowArticleComponent } from './show-article/show-article.component';
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    DashboardComponent,
    NewsComponent,
    AddUserComponent,
    AddCategoryComponent,
    AddArticleComponent,
    RegisterComponent,
    ShowArticleComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule,FormsModule,
    EditorModule, QuillModule.forRoot(), NgxEditorModule,
    ReactiveFormsModule, NgxSimpleTextEditorModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
