import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-tarjeta-credito',
  templateUrl: './tarjeta-credito.component.html',
  styleUrls: ['./tarjeta-credito.component.css']
})
export class TarjetaCreditoComponent implements OnInit{

  form:FormGroup

  listTarjetas:any[]=[
    {titular:'Juan Perez 1', numeroTarjeta:'1212121', fechaExpiracion:'11/23',cvv:'123'},
    {titular:'Juan Perez 2', numeroTarjeta:'1212121', fechaExpiracion:'11/23',cvv:'123'}

  ];

  constructor(private fb:FormBuilder){
     this.form=this.fb.group(
      {
        titular:[''],
        numeroTarjeta:[''],
        fechaExpiracion:[''],
        cvv:[''],

      }
     )
  }

  ngOnInit(): void {
    
  }

  agregarTarjeta(){
    console.log(this.form)
    const tarjeta:any={
      titular:this.form.get('titular')?.value,
      numeroTarjeta:this.form.get('numeroTarjeta')?.value,
      fechaExpiracion:this.form.get('fechaExpiracion')?.value,
      cvv:this.form.get('cvv')?.value,
    }
    this.listTarjetas.push(tarjeta)
    this.form.reset()
    console.log(tarjeta)
  }
}
