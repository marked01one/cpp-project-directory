import React from 'react'
import { Card } from 'flowbite-react'
import CardMajor from '../components/CardMajor';
import CardCompensation from '../components/CardCompensation';

type Props = {
  name: string,
  org: string,
  desc: string,
  majors: string[],
  comp: string
}

export default function ProjectCard({name, desc, org, majors, comp}: Props) {
  const majorsEnd = majors.length - 1;

  function cleanMajors(major: string): React.JSX.Element {
    if (majorsEnd == 0) 
      return <>🎓 <p className='hover:underline hover:font-semibold inline'>{major}</p></>


    if (majors.indexOf(major) == majorsEnd) {
      return <p className='hover:underline hover:font-semibold inline'>{major}</p>
    }
    else if (majors.indexOf(major) == 0) {
      return <>🎓&nbsp;&nbsp;<p className='hover:underline hover:font-semibold inline'>{major}</p>,&nbsp;</>
    }
    else {
      return (
        <><p className='hover:underline hover:font-semibold inline'>{major}</p>,&nbsp;</>
      )
    }
  }
  
  return (
    <Card href="#" className='max-w-6xl my-2'>
      <div className='grid grid-cols-4 gap-2'>
        <div className='col-span-3'>
          <h5 className='text-2xl font-bold tracking-tight dark:text-blue-500 hover:underline'>
            {name}
          </h5>
          <p className='text-md underline font-normal text-gray-600 dark:text-gray-200'>
            {org}
          </p>
          <p className='text-gray-700 dark:text-gray-400 line-clamp-2 min-h-12 mt-2'>
            {desc}
          </p>
          
          <div>
            <CardCompensation compensation={comp} />
          </div>
        </div>
          
          
        <div>
          <div className='text-sm text-right font-normal text-gray-600 dark:text-gray-200 flex flex-wrap'>
             {majors.map(m => <CardMajor majors={majors} maj={m} />)} 
          </div>
        </div>
      </div>
      
    </Card>
  )
}
