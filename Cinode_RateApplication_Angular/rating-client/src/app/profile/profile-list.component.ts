import { Component, Input, ChangeDetectionStrategy } from '@angular/core';
import { Profile } from '../core';

@Component({
  selector: 'profile-list',
  templateUrl: './profile-list.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ProfileListComponent {
  @Input() profiles: Profile[];

  trackByProfile(index: number, profile: Profile): string {
    return profile.id.toString();
  }
}
