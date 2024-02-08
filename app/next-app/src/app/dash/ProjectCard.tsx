import React from 'react'
import { Card } from 'flowbite-react'

type Props = {
  name: string,
  org: string,
  desc: string,
  majors: string[],
  comp: string
}

export default function ProjectCard({name, desc, org, majors, comp}: Props) {
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
            {comp != "Volunteer" ? 
              <span className='font-semibold text-green-500'>💵 Paid {comp.toLowerCase()}</span> : 
              <span className='text-yellow-500'>🙋 Volunteer</span>  
            }
          </div>
        </div>
          
          
        <div>
          <div className='text-md text-right font-normal text-gray-600 dark:text-gray-200'>
            🎓 {majors.toString().replaceAll(',', ', ')} 
          </div>
        </div>
      </div>
      
    </Card>
  )
}
