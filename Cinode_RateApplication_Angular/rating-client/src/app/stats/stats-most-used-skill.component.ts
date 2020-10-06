import { Component, Input } from '@angular/core';
import { MostUsedSkill } from '../core/models/most-used-skill';

@Component({
  selector: 'stats-most-used-skill',
  templateUrl: './stats-most-used-skill.component.html',
  styleUrls: ['../shared/styles/tables.css'],
})
export class MostUsedSkillsComponent {
  @Input() mostusedskills: MostUsedSkill[];

  trackByMus(index: number, mus: MostUsedSkill): string {
    return mus.id.toString();
  }
}
