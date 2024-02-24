import { Contacts } from '@/types';
import React from 'react'
import { MdOutlineEmail } from 'react-icons/md'
import { FaDiscord, FaPhone } from 'react-icons/fa6';

type Props = {
    contacts: Contacts
}

export default function CardContacts({contacts}: Props) {
  const iconStyles = {
    display: 'inline',
    marginRight: '0.5rem'
  };
  
    return (
    <div className='lg:inline hidden'>
      {contacts.email ? (
        <div className='underline underline-offset-2'>
          <MdOutlineEmail style={iconStyles} size={16} />
          {contacts.email}
        </div>
      ) : null}
      {contacts.phone ? (
        <div className='underline underline-offset-2'>
          <FaPhone style={iconStyles} size={12} />
          {contacts.phone}
        </div>
      ) : null}
      {contacts.phone ? (
        <div>
          <FaDiscord style={iconStyles} size={16} />
          @<span className='underline underline-offset-2'>{contacts.discord}</span>
        </div>
      ) : null}
    </div>
  )
}
