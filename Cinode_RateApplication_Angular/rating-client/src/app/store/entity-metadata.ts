import { EntityMetadataMap } from '@ngrx/data';

const entityMetadata: EntityMetadataMap = {
  Profile: {},
  MostUsedSkill: {},
};

const pluralNames = { Profile: 'Profiles', MostUsedSkill: 'MostUsedSkills' };

export const entityConfig = {
  entityMetadata,
  pluralNames,
};
