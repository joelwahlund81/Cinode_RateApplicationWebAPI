import {
  ChangeDetectionStrategy,
  Component,
  EventEmitter,
  OnChanges,
  OnInit,
  Output,
  SimpleChanges,
} from '@angular/core';
import { Profile, Skills } from '../core';

@Component({
  selector: 'profile-signup',
  templateUrl: './profile-signup.component.html',
  styleUrls: ['./profile-signup.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ProfileSignUpComponent implements OnChanges, OnInit {
  @Output() save = new EventEmitter<Profile>();

  newProfile: Profile;
  skillRating: number;
  skillName: string = '';
  firstName: string = '';
  lastName: string = '';

  ngOnInit(): void {
    this.emptyProfile();
  }

  ngOnChanges(changes: SimpleChanges): void {
    this.emptyProfile();
  }

  addSkill() {
    const skill: Skills = {
      skill: this.skillName,
      rating: this.skillRating,
      profileId: 0,
    };
    this.newProfile.skills.push(skill);
    console.log(this.newProfile);
    this.skillName = '';
  }

  removeSkill(skill: Skills, i: number) {
    console.log(skill, i);
    const rs = [...this.newProfile.skills];

    this.newProfile.skills.splice(i, 1);
  }

  SkillRatingArray(): any[] {
    return Array(6);
  }

  setSkillRating(rating: number) {
    this.skillRating = rating;
  }

  emptyProfile() {
    this.newProfile = {
      id: undefined,
      firstName: '',
      lastName: '',
      isAnonymous: false,
      skills: new Array<Skills>(),
    };
  }

  clear() {
    this.emptyProfile();
    this.firstName = '';
    this.lastName = '';
  }

  saveProfile() {
    console.log('save');
    this.newProfile.firstName = this.firstName;
    this.newProfile.lastName = this.lastName;
    this.save.emit(this.newProfile);
    this.clear();
  }
}
