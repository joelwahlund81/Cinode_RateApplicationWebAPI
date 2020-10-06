import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StatsComponent } from './stats.component';
import { MostUsedSkillsComponent } from './stats-most-used-skill.component';

@NgModule({
  imports: [CommonModule],
  exports: [StatsComponent],
  declarations: [StatsComponent, MostUsedSkillsComponent],
})
export class StatsModule {}
