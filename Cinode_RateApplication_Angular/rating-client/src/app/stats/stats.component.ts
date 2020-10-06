import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { MostUsedSkill } from '../core/models/most-used-skill';
import { StatsService } from './stats.service';

@Component({
  selector: 'stats',
  templateUrl: './stats.component.html',
  styleUrls: ['../shared/styles/title.css'],
})
export class StatsComponent implements OnInit {
  mostusedskills$: Observable<MostUsedSkill[]>;
  constructor(private statsService: StatsService) {
    this.mostusedskills$ = statsService.entities$;
  }

  ngOnInit() {
    this.getMostUsedSkill();
  }

  getMostUsedSkill() {
    this.statsService.getAll();
  }
}
