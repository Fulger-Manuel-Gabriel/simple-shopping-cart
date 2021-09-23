import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ElipsisPipe } from './pipe/elipsis.pipe';
import { ProductComponent } from './product/product.component';



@NgModule({
  declarations: [
    ElipsisPipe,
    ProductComponent
  ],
  imports: [
    CommonModule
  ],
  exports : [
    ElipsisPipe,
    ProductComponent
  ]
})
export class CoreModule { }
