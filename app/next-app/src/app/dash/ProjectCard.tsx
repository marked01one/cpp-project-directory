import React from 'react'
import { Card } from 'flowbite-react'
import CardMajor from './cards/CardMajor';
import CardCompensation from './cards/CardCompensation';
import { Project } from '@/types';
import CardContacts from './cards/CardContacts';

type Props = {
  proj: Project
}

export default function ProjectCard({proj}: Props) {
  
  return (
    <Card href="#" className='max-w-6xl my-2'>
      <div className='grid grid-cols-4 gap-0'>
        <div className='col-span-3 float-left'>
          <h5 className='text-2xl font-bold tracking-tight dark:text-blue-500 hover:underline'>
            {proj.name}
          </h5>
          <p className='text-md underline font-normal text-gray-600 dark:text-gray-200'>
            {proj.organization}
          </p>
        </div>
        <div className='float-right flex flex-wrap justify-end font-normal text-gray-600 dark:text-gray-200'>
          {proj.majors.map(m => 
            <CardMajor majors={proj.majors} maj={m} key={m} />)} 
        </div>
      </div>
      <div className='lg:grid grid-cols-4 gap-2'>
        <div className='col-span-3'>
          <p className='text-gray-700 dark:text-gray-400 line-clamp-2 min-h-12'>
            {proj.description}
          </p>
          <CardCompensation compensation={proj.compensation} />
        </div>
        <div className='
          text-sm mt-auto lg:text-end font-normal 
          text-gray-600 dark:text-gray-200'>
          <CardContacts contacts={proj.contacts} />
        </div>  
      </div>
    </Card>
  )
}
