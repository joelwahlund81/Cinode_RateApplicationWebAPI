import { Component, Input } from '@angular/core';
import { Profile } from '../core';

@Component({
  selector: 'profile-list-entity',
  templateUrl: './profile-list-entity.component.html',
  styleUrls: ['./profile-list-entity.component.css'],
})
export class ProfileListEntityComponent {
  @Input() profile: Profile;
}
