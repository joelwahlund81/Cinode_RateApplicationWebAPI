import { Injectable } from '@angular/core';
import {
  EntityCollectionServiceBase,
  EntityCollectionServiceElementsFactory,
} from '@ngrx/data';
import { Profile } from '../core';

@Injectable({ providedIn: 'root' })
export class ProfileService extends EntityCollectionServiceBase<Profile> {
  constructor(serviceElementsFactory: EntityCollectionServiceElementsFactory) {
    super('Profile', serviceElementsFactory);
  }
}
