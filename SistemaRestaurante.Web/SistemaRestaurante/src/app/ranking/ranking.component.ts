import { Component, OnInit } from '@angular/core';
import { PRATOS } from '../shared/Prato.mock';
import { Prato } from '../shared/Prato.model';
import { PratoService } from '../prato.service'

@Component({
  selector: 'app-ranking',
  templateUrl: './ranking.component.html',
  styleUrls: ['./ranking.component.css']
})
export class RankingComponent implements OnInit {

  public Pratos: Prato[] = PRATOS;
  private prato = this.pratoService.ObtenhaPrato('a');

  constructor(private pratoService : PratoService) { }

  ngOnInit() {
  }

}
