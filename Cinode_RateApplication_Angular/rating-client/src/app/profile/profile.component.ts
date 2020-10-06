import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Profile } from '../core';
import { ProfileService } from './profile.service';

@Component({
  selector: 'profile',
  templateUrl: './profile.component.html',
  styleUrls: ['../shared/styles/title.css'],
})
export class ProfileComponent implements OnInit {
  profiles$: Observable<Profile[]>;
  constructor(private profileService: ProfileService) {
    this.profiles$ = profileService.entities$;
  }

  ngOnInit() {
    this.getProfiles();
  }

  add(profile: Profile) {
    console.log(profile);
    this.profileService.add(profile);
  }

  getProfiles() {
    this.profileService.getAll();
  }

  save(profile: Profile) {
    console.log('save');
    this.add(profile);
  }
}
