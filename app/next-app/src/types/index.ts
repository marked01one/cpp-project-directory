export type Project = {
  id: string,
  name: string,
  organization: string,
  compensation: string,
  description: string,
  majors: string[],
  contacts: Contacts
}

export type Contacts = {
  email: string,
  discord: string,
  phone: string
}