import { Injectable } from '@angular/core';
import {
  EntityCollectionServiceBase,
  EntityCollectionServiceElementsFactory,
} from '@ngrx/data';
import { MostUsedSkill } from '../core';

@Injectable({ providedIn: 'root' })
export class StatsService extends EntityCollectionServiceBase<MostUsedSkill> {
  constructor(serviceElementsFactory: EntityCollectionServiceElementsFactory) {
    super('MostUsedSkill', serviceElementsFactory);
  }
}
