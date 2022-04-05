import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {


  public eventos : any = [];
  public eventosFiltred : any = [];

  widthImg = 150;
  marginImg = 2;
  showImg =true;
 private _list : string = ' ';

 public get list (): string{
   return this._list;
 }

 public set list( value: string){
   this._list = value;
   this.eventosFiltred = this.list ? this.filterEvents(this.list) :
   this.eventos
 }

 filterEvents (filterFor: string) : any {
    filterFor = filterFor.toLocaleLowerCase();

    return this.eventos.filter(
      (evento: { tema: string; local : string; }) => evento.tema
    .toLocaleLowerCase()
    .indexOf(filterFor) !== -1 
    );
  }

  constructor(private http:HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  showImgs() {
    this.showImg = !this.showImg;
  }

  public getEventos () : void {
 this.http.get('https://localhost:5001/api/evento').subscribe(
  response=> {
    this.eventos = response;
    this.eventosFiltred = this.eventos;
  },
 error=> console.log(error)

  );


  }
}
