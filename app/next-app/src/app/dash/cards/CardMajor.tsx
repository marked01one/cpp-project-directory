import React from 'react'
import { FaGraduationCap } from 'react-icons/fa6'

type Props = {
  majors: string[],
  maj: string
}

export default function CardMajor({majors, maj}: Props) {
  const iconStyles = {
    display: 'inline',
    marginRight: '0.5rem'
  };
  
  if (majors.length == 1)
    return (
      <>
        <FaGraduationCap style={iconStyles} size={16} />
        <span className='
          hover:underline hover:font-semibold'>
          {maj}
        </span>
      </>
    );
  
  const end = majors.length - 1;

  switch (majors.indexOf(maj)) {
    case 0:
      return (
        <>
          <FaGraduationCap style={iconStyles} size={16} />
          <span className='
            hover:underline hover:font-semibold'>
            {maj}
          </span>
          ,&nbsp;
        </>
      )
    
    case end:
      return (
        <>
          <span className='
            hover:underline hover:font-semibold'>
            {maj}
          </span>
        </>
      )

    default:
      return (
        <>
          <span className='
            hover:underline hover:font-semibold'>
            {maj}
          </span>
          ,&nbsp;
        </>
      )
  }
}
