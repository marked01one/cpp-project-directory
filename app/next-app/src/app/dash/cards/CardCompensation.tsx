import React from 'react'
import { FaMoneyBill } from 'react-icons/fa6'
import { HiHandRaised } from 'react-icons/hi2' 

type Props = {
  compensation: string
}

export default function CardCompensation({compensation}: Props) {
  const iconStyles = {
    display: 'inline',
    marginRight: '0.5rem'
  };

  if (compensation == "Volunteer")
    return (
      <span className='text-yellow-500'>
        <HiHandRaised style={iconStyles}/>
        Volunteer
      </span>
    );
  
  return (
    <span className='font-semibold text-green-500'>
      <FaMoneyBill style={iconStyles} /> 
      Paid {compensation.toLowerCase()}
    </span>
  );
}
