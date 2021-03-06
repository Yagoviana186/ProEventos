import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.geteventos();
  }

  public geteventos(): void{

    this.http.get('https://localhost:5001/api/eventos').subscribe(
      Response => this.eventos = Response,
      error   => console.log(error)
   );


}


}
