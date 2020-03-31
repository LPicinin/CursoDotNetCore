import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {
  eventos: any = [
    {
      EventosId: 1,
      Tema: 'Angular',
      Local:'Belo Horizonte'
    },
    {
      EventosId: 2,
      Tema: '.NET Core',
      Local:'São Paulo'
    },
    {
      EventosId: 3,
      Tema: 'Angular e .NET Core',
      Local:'Rio de Janeiro'
    }
  ];
  constructor() {}

  ngOnInit() {}
}
