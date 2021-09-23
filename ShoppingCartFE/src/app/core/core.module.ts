import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ElipsisPipe } from './pipe/elipsis.pipe';



@NgModule({
  declarations: [
    ElipsisPipe
  ],
  imports: [
    CommonModule
  ],
  exports : [
    ElipsisPipe
  ]
})
export class CoreModule { }
